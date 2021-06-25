using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O_Auth_Demo.Controllers
{
    [ApiController]
    [Route("api/JustA")]
    public class JustAController : ControllerBase
    {
        private readonly AuthConfigurations _authConfigurations;
        private readonly ILogger<JustAController> _logger;

        public JustAController(ILogger<JustAController> logger, IOptions<AuthConfigurations> authConfigurations)
        {
            _logger = logger;
            _authConfigurations = authConfigurations.Value;
        }

        [HttpGet, Authorize]
        public String Get()
        {
            return "Hello";
        }
    }
}
