using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SandBoxAPI.Common;
using SandBoxAPI.Interfaces.Services;
using SandBoxAPI.Models;
using SandBoxAPI.Services;

namespace SandBoxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _weatherService = new WeatherService();
        }

        [HttpGet]
        public HttpResponse<List<WeatherForecast>> Get([FromHeader] string headerExample, [FromBody]BodyModel bodyExample)
        {
            var weatherList = _weatherService.GetAll();
            _logger.LogInformation("WeatherForecast - GetAll");

            return new HttpResponse<List<WeatherForecast>>
            {
                IsStatusCodeSuccess = true,
                statusCode = HttpStatusCode.OK,
                data = weatherList
            };
        }
    }
}
