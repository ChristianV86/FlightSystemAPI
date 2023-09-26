using FlightSystem.DAL;
using FlightSystem.DAL.Data;
using FlightSystem.DAL.Repository;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.WebAPI.Controllers;

namespace WebApiUnitTesting
{
    public class JourneyTesting
    {
        private readonly JourneyController _controller;
        private readonly IJourneyRepository _service;

        public JourneyTesting()
        {
            _service = new JourneyRepository();
            _controller = new JourneyController(_service);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}