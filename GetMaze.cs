using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace maze_agent_func
{
    public static class GetMaze
    {
        [FunctionName("GetMaze")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "maze")]
            HttpRequest req, 
            ILogger log)
        {
            log.LogInformation("GetMaze-Entry");

            string name = req.Query["name"];

            log.LogInformation("GetMaze-Exit");
            
            return name != null
                ? (ActionResult) new OkObjectResult($"Hello, {name}")
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
            
        }
    }
}