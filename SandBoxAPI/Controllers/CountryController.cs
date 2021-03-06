﻿
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SandBoxAPI.Models;
using SandBoxAPI.Services;

namespace SandBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : CustomController<Country, CountryService>
    {
        public CountryController(CountryService service, ILogger<CountryController> logger) : base(service, logger) { }
    }
}
