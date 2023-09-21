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
        [Required(ErrorMessage = "{0} es Obligatorio")]        
        public string DepartureStation { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]        
        public string ArrivalStation { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]        
        public string FlightCarrier { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]        
        public int FlightNumber { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        public double Price { get; set; }
    }
}
