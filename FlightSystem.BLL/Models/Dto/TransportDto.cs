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
        [Required(ErrorMessage = "{0} es Obligatorio")]
        [MaxLength(2)]
        public string FlightCarrier { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        public int FlightNumber { get; set; }

        [ForeignKey("FlightNumber")]
        public FlightDto FlightId { get; set;}
    }
}
