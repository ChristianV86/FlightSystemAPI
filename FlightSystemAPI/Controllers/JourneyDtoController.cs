using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneyDtoController : ControllerBase
    {
        private readonly ILogger<JourneyDtoController> _logger;

        public JourneyDtoController(ILogger<JourneyDtoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<JourneyDto> GetJourneys()
        {
            _logger.LogInformation("All journeys were obtained.");
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
                _logger.LogError("Some of the parameters were sent empty.");
                return BadRequest();
            }

            if (origin == null && destination == null)
            {
                _logger.LogError("Search was sent without any parameter specified.");
                return BadRequest();
            }            

            var route = JourneyStore.journeyList.Where(r =>
                                                      r.Origin == origin.ToUpper() &&
                                                      r.Destination == destination.ToUpper()).ToList();

            if (route.Count > 0)
            {
                return Ok(route);
            }
            return NotFound("No se encontró esa ruta.");           
        }      
    }
}
