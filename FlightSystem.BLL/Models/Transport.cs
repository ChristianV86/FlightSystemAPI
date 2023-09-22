using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Models
{
    public class Transport
    {
        [Key]
        [MaxLength(4, ErrorMessage = "Maximum 4 Characters")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "The primary key must contain only numbers.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FlightNumber { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        [MaxLength(2, ErrorMessage = "Maximum 2 Characters")]
        public string FlightCarrier { get; set; }
    }
}
