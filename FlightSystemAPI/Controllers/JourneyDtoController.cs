using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyDtoController : ControllerBase
    {    
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<JourneyDto> GetJourneys()
        {
            return JourneyStore.journeyList;
        }

        [HttpGet("SearchFlight", Name = "GetJourney")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<JourneyDto> GetJourney(
                                                    [StringLength(3, MinimumLength = 3)]
                                                    [RegularExpression(@"^[a-zA-Z]+$")] 
                                                    string origin,
                                                    [StringLength(3, MinimumLength = 3)]
                                                    [RegularExpression(@"^[a-zA-Z]+$")]
                                                    string destination)
        {             
            if(origin == null || destination == null)
            {
                return BadRequest();
            }

            if (origin == null && destination == null)
            {
                return BadRequest();
            }
            //var flight = JourneyStore.journeyList.FirstOrDefault(f => 
            //                                                     f.Origin == origin.ToLower() && 
            //                                                     f.Destination == destination.ToLower());

            var route = JourneyStore.journeyList.Where(r=>
                                                      r.Origin == origin.ToLower() &&
                                                      r.Destination == destination.ToLower()).ToList();

            if (route.Count > 0)
            {
                return Ok(route);
            }            
            return NotFound("No se encontró esa ruta.");
        }      
    }
}
