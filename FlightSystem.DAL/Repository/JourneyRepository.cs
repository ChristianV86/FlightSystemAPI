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
    public class JourneyRepository: GenericRepository<Journey>, IJourneyRepository
    {
        private readonly ApplicationDbContext _context;       

        public JourneyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Journey> Update(Journey entity)
        {
            _context.Journeys.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
