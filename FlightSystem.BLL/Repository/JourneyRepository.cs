using FlightSystem.DAL.Data;
using FlightSystem.DAL.Models;
using FlightSystem.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Repository
{
    public class JourneyRepository : GenericRepository<Journey>, IJourneyRepository
    {
        private readonly ApplicationDbContext _context;

        public JourneyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }        

        List<Flight> IJourneyRepository.GetRoute(string origin, 
                                                 string destination)
        {
            // We create a new instance of a generic list of objects of type Flight.
            List<Flight> flight = new List<Flight>();

            string currentLocation = origin;

            while (currentLocation != destination)
            {
                // Find the next flight from the current location
                var nextFlight = _context.Flights.FirstOrDefault(f => f.Origin == currentLocation);

                if (nextFlight == null)
                {
                    // No valid flight found to continue. No valid flight found to continue
                    return null;
                }
                flight.Add(nextFlight);
                currentLocation = nextFlight.Destination;

                // We check if the number of flights in the journey list is greater than the total number of flights available in the database.
                if (flight.Count > _context.Flights.Count())
                {
                    return null;
                }
            }
            return flight;
        }
    }
}
