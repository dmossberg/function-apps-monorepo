using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace NorthwindFunctionApp
{
    public static class FunctionA
    {
        [FunctionName("NorthwindFunctionA")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string responseMessage =
                "Hello, from NORTHWIND Function A. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
