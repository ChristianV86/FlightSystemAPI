using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Models
{
    public class Journey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [MaxLength(3, ErrorMessage = "Maximum 3 Characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters allowed.")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [MaxLength(3, ErrorMessage = "Maximum 3 Characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters allowed.")]
        public string Destination { get; set; }        

        [Required(ErrorMessage = "{0} is mandatory")]
        public double Price { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public List<Flight> Flights { get; set; }
    }
}
