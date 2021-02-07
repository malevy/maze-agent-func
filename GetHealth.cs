using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace maze_agent_func
{
    public static class GetHealth
    {
        public class GetHealthResponse
        {
            [JsonProperty("status")]
            public string Status;
        }
        
        [FunctionName("GetHealth")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = ".well-known/health")]
            HttpRequest req, 
            ILogger log)
        {
            log.LogInformation("getHealth-entry");

            var response = new GetHealthResponse
            {
                Status = "up"
            };
            
            log.LogInformation("getHealth-exit");

            return new OkObjectResult(response);

        }
    }
}