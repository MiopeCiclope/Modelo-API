using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SandBoxAPI;
using SandBoxAPI.Data;
using SandBoxAPI.Services;

namespace SandBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastsController : CustomController<WeatherForecast, WeatherForecastService>
    {
        private readonly WeatherForecastService _service;
        public WeatherForecastsController(WeatherForecastService service) : base(service)
        {
            this._service = service;
        }

        // GET: api/WeatherForecasts
        [HttpGet]
        public List<WeatherForecast> GetWeatherForecast()
        {
            return this._service.GetAll();
        }
    }
}
