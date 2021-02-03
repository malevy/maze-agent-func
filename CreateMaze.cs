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
    public static class CreateMaze
    {
        [FunctionName("CreateMaze")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "maze")]
            HttpRequest req, ILogger log)
        {
            log.LogInformation("create-maze: entry");
            return new OkObjectResult("{}");

        }
    }
}