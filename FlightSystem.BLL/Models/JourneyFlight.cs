using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.DAL.Models
{
    public class JourneyFlight
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int JourneyId { get; set; }

        [ForeignKey("JourneyId")]
        public Journey Journey { get; set; }

        public int FlightId { get; set; }

        [ForeignKey("FlightId")]
        public Fligth Fligth { get; set; }
    }
}
