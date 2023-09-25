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
        [Required(ErrorMessage = "{0} is mandatory")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Only 3 letters are allowed.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Numbers are not allowed.")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Only 3 letters are allowed.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Numbers are not allowed.")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public double Price { get; set; } 

        [Required(ErrorMessage = "{0} is mandatory")]
        public List<FlightDto> Flights { get; set; }        
    }
}
