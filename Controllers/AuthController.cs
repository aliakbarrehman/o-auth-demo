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
    [Route("auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthConfigurations _authConfigurations;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IOptions<AuthConfigurations> authConfigurations)
        {
            _logger = logger;
            _authConfigurations = authConfigurations.Value;
        }

        [HttpGet]
        public String Get()
        {
            return "Hello";
        }
    }
}
