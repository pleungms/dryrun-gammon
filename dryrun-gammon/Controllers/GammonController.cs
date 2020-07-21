using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dryrun_gammon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GammonController : ControllerBase
    {
        public string Get(int id)
        {
            return "Hello World! Including CI/CD include Teams notification";
        }

    }
}
