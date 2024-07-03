using Microsoft.AspNetCore.Routing.Matching;
using System.Net;

namespace ApiNet8.Models
{
    public class RespuestaAPI
    {
        public RespuestaAPI()
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<String> ErrorMessages { get; set; }
        public object? Result { get; set; }

    }
}
