using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SandBoxAPI.Common
{
    public class HttpResponse<T>
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsStatusCodeSuccess { get; set; }
        public T data { get; set; }
    }
}
