using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DependencyCollector;
using Microsoft.ApplicationInsights.Extensibility;

namespace dryrun_gammon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GammonController : ControllerBase
    {
        public string Get(int id)
        {
            // Sample code to add Azure Application Insights
            TelemetryConfiguration configuration = TelemetryConfiguration.CreateDefault();
            configuration.InstrumentationKey = "6cc55fe5-2175-4ffd-a91e-03c9d2d09e6e";
            var telemetryClient = new TelemetryClient(configuration);
            telemetryClient.TrackTrace("Gammon Controller Get Id");

            return "Hello World! Including CI/CD include Teams notification";
        }

    }
}
