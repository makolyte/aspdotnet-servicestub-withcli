using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;

namespace ServiceStub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthStatusController : ControllerBase
    {
        public static HealthStatus Status { get; set; } = HealthStatus.Healthy;
        [HttpGet()]
        public string Get()
        {
            Console.WriteLine("Request received: GET /HealthStatus");
            return Status.ToString();
        }
    }
}
