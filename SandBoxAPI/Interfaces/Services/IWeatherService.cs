using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Interfaces.Services
{
    public interface IWeatherService
    {
        List<WeatherForecast> GetAll();
    }
}
