using FlightSystem.BLL.Models;
using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JourneyDtoController : ControllerBase
    {            
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<JourneyDto>> GetJourneys()
        {            
            return JourneyStore.journeyList;
        }

        [HttpGet("SearchJourney", Name = "GetJourney")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<JourneyDto>>  GetJourney([StringLength(3, MinimumLength = 3)][RegularExpression(@"^[a-zA-Z]+$")]string origin,
                                                                [StringLength(3, MinimumLength = 3)][RegularExpression(@"^[a-zA-Z]+$")]string destination)
        {
            try
            {
                if (origin == null || destination == null || (origin == null && destination == null))
                {
                    return BadRequest("Some of the parameters were sent empty.");
                }

                var route = JourneyStore.journeyList.Where(r =>
                                                           r.Origin == origin.ToUpper() &&
                                                           r.Destination == destination.ToUpper()).ToList();

                if (route.Count > 0)
                {
                    return Ok(route);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred in the request.");
                ex.Message.ToString();                       
            }
            return NotFound("There is no route that allows you to reach that destination.");
        }
    }
}
