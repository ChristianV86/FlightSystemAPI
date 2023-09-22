using FlightSystem.BLL;
using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Data;
using FlightSystem.DAL.Models;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        // We inject access service to the database
        private readonly ApplicationDbContext _context;
        // We inject access service to external API
        private readonly HttpClient _httpClient;
        private readonly ILogger<ExternalDataController> _logger;

        public FlightController(ApplicationDbContext context,
                                HttpClient httpClient,
                                ILogger<ExternalDataController> logger)
        {
            _context = context;
            _httpClient = httpClient;
            _logger = logger;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetDataFromExternalAPI()
        {       
            {
                try
                {
                    // Make a GET request to the external API
                    //var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/0");
                    //var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/1");
                    var response = await _httpClient.GetAsync("https://recruiting-api.newshore.es/api/flights/2");
                    
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and return data
                        var json = await response.Content.ReadAsStringAsync();
                        // We deserialize the data
                        var result = JsonConvert.DeserializeObject<List<Flight>>(json);                     

                        // Guarda los datos en la base de datos.
                        var data = new Flight {  };
                        _context.Fligths.Add(data);
                        await _context.SaveChangesAsync();

                        return Ok("Datos almacenados en la base de datos.");
                    }
                    else
                    {
                        return BadRequest($"Error en la solicitud: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Error: {ex.Message}");
                }
            }
        }


    }
}
