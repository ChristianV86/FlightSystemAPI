using FlightSystem.BLL.Models.Dto;
using FlightSystem.WebAPI.DataStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDtoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<FlightDto> GetFlights()
        {
            return FlightStore.flightList;
        }

        [HttpGet("id:int")]
        public FlightDto GetFlight(int id)
        {
            return FlightStore.flightList.FirstOrDefault(f => f.FlightNumber == id);
        }
    }
}
