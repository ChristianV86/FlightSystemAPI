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
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        private readonly ApplicationDbContext _context;

        public FlightRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
    }
}
