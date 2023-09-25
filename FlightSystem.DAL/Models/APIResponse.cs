using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.BLL.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode {  get; set; }

        public bool Success { get; set; } = true;

        public List<string> ErrorMesssages { get; set; }

        public object Result { get; set; }
    }
}
