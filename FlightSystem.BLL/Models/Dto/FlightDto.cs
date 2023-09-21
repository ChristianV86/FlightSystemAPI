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
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        [MaxLength(3)]
        public string DepartureStation { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        [MaxLength(3)]
        public string ArrivalStation { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        public double Price { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]        
        public List<TransportDto> Transports { get; set; }             
    }
}
