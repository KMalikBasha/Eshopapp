using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Response
    {
        public int Id { get; set; }
        public int StatusCode { get; set; } 
        public string StatusMessage { get; set; }
        public Users Data { get; set; }

    }
}
