using FlightSystem.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalDataController : ControllerBase
    {
        // We inject access service to external API
        private readonly ExternalApiService _externalApiService;
        private readonly ILogger<ExternalDataController> _logger;

        public ExternalDataController(ExternalApiService externalApiService, ILogger<ExternalDataController> logger )
        {
            _externalApiService = externalApiService;
            _logger = logger;
        }

        // We get the data from the external API
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetExternalData()
        {
            var externalData = await _externalApiService.GetExternalDataAsync();

            if (externalData != null)
            {
                _logger.LogInformation("Data is being fetched from external API.");
                return Ok(externalData);
            }
            else
            {
                _logger.LogInformation("There was a problem taking data from the external API.");
                return BadRequest();
            }
        }
    }
}
