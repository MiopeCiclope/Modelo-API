using SandBoxAPI.Data;
using SandBoxAPI.Repositories;

namespace SandBoxAPI.Services
{

    public class WeatherForecastService : Service<WeatherForecast, SandBoxAPIContext, WeatherRepository>
    {       
        public WeatherForecastService(SandBoxAPIContext context, WeatherRepository baseRepository) : base(context, baseRepository) { }
    }
}
