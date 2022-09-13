using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Escola.Api.Controllers
{
    [Route("[controller]")]
    public class BoletinsController : Controller
    {
        private readonly ILogger<BoletinsController> _logger;

        public BoletinsController(ILogger<BoletinsController> logger)
        {
            _logger = logger;
        }
    }
}