using SandBoxAPI.Data;
using SandBoxAPI.Interfaces;
using SandBoxAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Services
{

    public class WeatherForecastService : Service<WeatherForecast, SandBoxAPIContext, WeatherRepository>
    {       
        public WeatherForecastService(SandBoxAPIContext context, WeatherRepository baseRepository) : base(context, baseRepository) { }
    }
}
