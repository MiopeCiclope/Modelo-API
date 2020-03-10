using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SandBoxAPI.Common;
using SandBoxAPI.Models;

namespace SandBoxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public HttpResponse<List<WeatherForecast>> Get([FromHeader] string headerExample, [FromBody]BodyModel bodyExample)
        {
            _logger.LogTrace("Não Aparece nada");
            _logger.LogInformation("Info verdinho tudo certo");
            _logger.LogWarning(headerExample);
            _logger.LogError(bodyExample.Key);
            _logger.LogCritical("Gzus me salva");

            var rng = new Random();
            var weatherList = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToList();

            return new HttpResponse<List<WeatherForecast>>
            {
                IsStatusCodeSuccess = true,
                statusCode = HttpStatusCode.OK,
                data = weatherList
            };
        }
    }
}
