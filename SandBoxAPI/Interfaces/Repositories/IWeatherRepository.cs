using System.Collections.Generic;

namespace SandBoxAPI.Interfaces.Repositories
{
    public interface IWeatherRepository
    {
        List<WeatherForecast> GetAll();
    }
}
