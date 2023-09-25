using FlightSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL.Models.Dto
{
    public class FlightDto
    {       
        [Required(ErrorMessage = "{0} is mandatory")]        
        public string DepartureStation { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string ArrivalStation { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string FlightCarrier { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string FlightNumber { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public double Price { get; set; }
    }
}
