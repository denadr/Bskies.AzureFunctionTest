using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using TestLibrary;

namespace TestFunction
{
    public static class TestFunction
    {
        [FunctionName("TestFunction")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)]HttpRequestMessage request, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            //string echo = TestService.Echo("Hello from Lib!");
            string echo = LibService.Echo("Hello from Lib!");
            
            return request.CreateResponse(HttpStatusCode.OK, echo);
        }
    }
}
