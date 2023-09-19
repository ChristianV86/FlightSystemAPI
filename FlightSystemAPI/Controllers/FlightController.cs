using FlightSystem.BLL.Models.Dto;
using FlightSystem.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.WebAPI.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<FlightDto> GetFligths()
        {
            return new List<FlightDto>
            {
                new FlightDto() {Id=1, Origin="MZL", Destination="BCN"},
                new FlightDto() {Id=2, Origin="MZL", Destination="JFK"}
            };
        }
    }
}
