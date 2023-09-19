using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL.Models.Dto
{
    public class FlightDto
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }        
    }
}
