using FlightSystem.BLL;
using FlightSystem.BLL.Models;
using FlightSystem.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalDataController : ControllerBase
    {
        // We inject access service to external API
        private readonly ExternalApiService _externalApiService;
        private readonly ILogger<ExternalDataController> _logger;
        protected APIResponse _apiResponse;

        public ExternalDataController(ExternalApiService externalApiService,
                                      ILogger<ExternalDataController> logger,
                                      APIResponse apiResponse)
        {
            _externalApiService = externalApiService;
            _logger = logger;
            _apiResponse = apiResponse;
        }

        //We get the data from the external API
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetExternalData()
        {
            var externalData = await _externalApiService.GetExternalDataAsync();

            try
            {
                _logger.LogInformation("Data obtained from an external API.");
                _apiResponse.Result = externalData;
                _apiResponse.StatusCode = HttpStatusCode.OK;
                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("There was a problem taking data from the external API.");
                _apiResponse.Success = false;
                _apiResponse.ErrorMesssages = new List<string>() { ex.ToString() };
                return _apiResponse;
            }
        }
    }
}
