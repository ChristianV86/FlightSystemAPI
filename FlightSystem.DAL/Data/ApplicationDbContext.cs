using FlightSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Data
{
    public class ApplicationDbContext: DbContext
    {
        // We apply dependency injection of the data access service
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  
            
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<JourneyFlight> JourneyFlights { get; set; }


    }
}
