using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class HttpResult
    {
        public int Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
