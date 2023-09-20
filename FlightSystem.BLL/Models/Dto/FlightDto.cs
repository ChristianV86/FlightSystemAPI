using FlightSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL.Models.Dto
{
    public class FlightDto
    {
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Transport { get; set; }
        public double Price { get; set; }
    }
}
