using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace mvc_angular.Controllers
{
    [Produces("application/json")]
    [Route("api/Configuration")]
    public class ConfigurationController : Controller
    {
        private readonly IConfiguration _configuration;
        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet("[action]")]
        public IActionResult ConfigurationData()
        {
            return Ok(new Dictionary<string, string>
            {
                { "IdentityServerAddress", _configuration["IdentityServerAddress"] },
                { "ApiAddress", _configuration["ApiAddress"] },
                { "AnotherAppSettingValue", _configuration["AnotherAppSettingValue"]}
            });
        }
    }
}


