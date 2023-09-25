using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Models
{
    public class Flight
    {
        [Key]        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [MaxLength(3, ErrorMessage = "Maximum 3 Characters")]
        [RegularExpression(@"^[A-Z]+$", ErrorMessage = "Only letters allowed.")]
        public string Origin { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [MaxLength(3, ErrorMessage = "Maximum 3 Characters")]
        [RegularExpression(@"^[A-Z]+$", ErrorMessage = "Only letters allowed.")]
        public string Destination { get; set; }        

        [Required(ErrorMessage = "{0} is mandatory")]
        public double Price { get; set; }
    }
}
