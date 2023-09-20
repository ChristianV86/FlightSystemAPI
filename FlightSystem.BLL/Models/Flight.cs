using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Models
{
    public class Flight
    {       
        [MaxLength(3)]
        public string DepartureStation { get; set; }

        [MaxLength(3)]
        public string ArrivalStation { get; set; }

        [MaxLength(2)]
        public string FlightCarrier { get; set; }

        [MaxLength(4)]
        public int FlightNumber { get; set; }

        public double Price { get; set; }                
    }
}
