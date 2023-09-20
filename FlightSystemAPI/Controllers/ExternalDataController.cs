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

        public ExternalDataController(ExternalApiService externalApiService)
        {
            _externalApiService = externalApiService;
        }

        // We get the data from the external API
        [HttpGet]
        public async Task<IActionResult> GetExternalData()
        {
            var externalData = await _externalApiService.GetExternalDataAsync();

            if (externalData != null)
            {
                return Ok(externalData);
            }
            else
            {
                return BadRequest("No se pudo obtener los datos de la API externa.");
            }
        }
    }
}
