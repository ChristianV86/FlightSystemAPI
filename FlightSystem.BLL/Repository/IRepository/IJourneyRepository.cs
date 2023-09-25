using FlightSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Repository.IRepository
{
    public interface IJourneyRepository : IGenericRepository<Journey>
    {        
        List<Flight> GetRoute(string origin, string destination);
    }
}
