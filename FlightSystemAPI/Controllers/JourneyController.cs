using AutoMapper;
using Azure;
using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Data;
using FlightSystem.DAL.Models;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyController : ControllerBase
    {
        public readonly IJourneyRepository _journeyRepo;
        public readonly IMapper _mapper;

        public JourneyController(IJourneyRepository journeyRepo,
                                 IMapper mapper)
        {
            _journeyRepo = journeyRepo;
            _mapper = mapper;
        }

        [HttpGet("SearchJourney")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Journey>> GetJourney([StringLength(3, MinimumLength = 3)][RegularExpression(@"^[a-zA-Z]+$")][FromQuery] string origin,
                                                            [StringLength(3, MinimumLength = 3)][RegularExpression(@"^[a-zA-Z]+$")][FromQuery] string destination)
        {
            var journey = await _journeyRepo.Get(j => j.Origin == origin && j.Destination == destination);

            try
            {
                var route = _journeyRepo.GetRoute(origin.ToUpper(), destination.ToUpper());                

                if(route == null)
                {
                    return BadRequest(/*"The route could not be calculated."*/);
                }

                if (route.Count == 0)
                {
                    return NoContent();
                }
                // Calculate the total price by adding the prices of the flights on the route
                double journeyPrice = route.Sum(f => f.Price);                

                // We create the response object with the desired information
                var journeyResponse = new 
                {
                    Origin = origin,
                    Destination = destination,
                    Price = journeyPrice,
                    Flights = route
                };                              

                return Ok(journeyResponse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }            
        }
    }
}
