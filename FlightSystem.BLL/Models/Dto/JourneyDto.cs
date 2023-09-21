using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL.Models.Dto
{
    public class JourneyDto
    {       
        [Required(ErrorMessage = "{0} es Obligatorio")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Sólo se permiten 3 letras.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No se permiten números.")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Sólo se permiten 3 letras.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "No se permiten números.")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "{0} es Obligatorio")]
        public double Price { get; set; } 

        [Required(ErrorMessage = "{0} es Obligatorio")]
        public List<FlightDto> Flights { get; set; }        
    }
}
