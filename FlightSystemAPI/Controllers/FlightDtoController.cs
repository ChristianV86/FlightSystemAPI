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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<FlightDto> GetFlights()
        {
            return FlightStore.flightList;
        }

        [HttpGet("id:int", Name = "GetFlight")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<FlightDto> GetFlight(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var flight = FlightStore.flightList.FirstOrDefault(f => f.FlightNumber == id);            
            
            if(flight == null)
            {
                return NotFound();
            }
            return Ok(flight);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]        
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FlightDto> CreateFlight([FromBody] FlightDto flightDto)
        {
            // If the model is not valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Personalized validation for flights
            //if (FlightStore.flightList.FirstOrDefault(f=>
            //                                          f.DepartureStation.ToLower() == flightDto.DepartureStation.ToLower() &&
            //                                          f.ArrivalStation.ToLower() == flightDto.ArrivalStation.ToLower() &&
            //                                          f.FlightCarrier.ToLower() == flightDto.FlightCarrier.ToLower()) != null)

            //{
            //    ModelState.AddModelError("FlightExist", "There is already a flight with that data");
            //}

            if(flightDto == null)
            {
                return BadRequest(flightDto);
            }
            if(flightDto.FlightNumber > 0)
            {
                // We prevent a BadRequest from being called when an internal error is generated
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            // We capture the id of the next record and add 1 to it so that it is created automatically and we add a new record to the list
            flightDto.FlightNumber = FlightStore.flightList.OrderByDescending(f => f.FlightNumber).FirstOrDefault().FlightNumber + 1;
            FlightStore.flightList.Add(flightDto);
            //return Ok(flightDto);
            // We create and call the route so that it returns the id that we are passing to it
            return CreatedAtRoute("GetFlight", new {id = flightDto.FlightNumber}, flightDto);
        }
    }
}
