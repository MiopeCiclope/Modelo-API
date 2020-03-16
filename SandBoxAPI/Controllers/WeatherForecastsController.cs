using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
