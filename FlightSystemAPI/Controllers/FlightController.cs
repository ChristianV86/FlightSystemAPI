using FlightSystem.DAL.Data;
using FlightSystem.DAL.Models;
using FlightSystem.DAL.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        //private readonly IFlightRepository _flightRepo;
        private readonly ApplicationDbContext _context;

        public FlightController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> Get()
        {

            return Ok(_context.Flights.ToList());
        }
    }
}
