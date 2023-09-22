using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL.Models.Dto
{
    public class TransportDto
    {        
        [Required(ErrorMessage = "{0} is mandatory")]        
        public string FlightCarrier { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string FlightNumber { get; set; }       
    }
}
