using FlightSystem.BLL.Models.Dto;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDtoController : ControllerBase
    {
        private readonly ILogger<FlightDtoController> _logger;

        public FlightDtoController(ILogger<FlightDtoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<FlightDto>> GetFlights()
        {
            _logger.LogInformation("All flights were obtained.");
            return FlightStore.flightList;
        }
    }
}
