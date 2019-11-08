using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

namespace Stripped.Controllers {
    public class HomeController : ApiController {
        [HttpGet]
        public HttpResponseMessage Get() {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "Succeed");

            response.Content = new StringContent(JsonConvert.SerializeObject(new {
                Code = 109,
                Message = "Succeed"
            }, Formatting.Indented), Encoding.UTF8, "text/plain");

            response.Headers.CacheControl = new CacheControlHeaderValue {
                MaxAge = TimeSpan.FromMinutes(20)
            };

            return response;
        }
    }
}