using SandBoxAPI.Data;
using SandBoxAPI.Interfaces.Repositories;
using SandBoxAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Services
{

    public class WeatherForecastService : Service<WeatherForecast, SandBoxAPIContext>
    {
        private readonly IWeatherRepository _weatherRepository;
        
        public WeatherForecastService(SandBoxAPIContext context) : base(context)
        {
            _weatherRepository = new WeatherRepository(this.context);
        }

        public List<WeatherForecast> GetAll()
        {
            return _weatherRepository.GetAll();
        }
    }
}
