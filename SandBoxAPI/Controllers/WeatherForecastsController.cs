using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SandBoxAPI;
using SandBoxAPI.Common;
using SandBoxAPI.Data;
using SandBoxAPI.Models;
using SandBoxAPI.Services;

namespace SandBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastsController : CustomController<WeatherForecast, WeatherForecastService>
    {
        public WeatherForecastsController(WeatherForecastService service, ILogger<WeatherForecastsController> logger) : base(service, logger) { }
    }
}
