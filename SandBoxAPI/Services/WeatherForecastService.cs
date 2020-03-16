using SandBoxAPI.Data;
using SandBoxAPI.Interfaces;
using SandBoxAPI.Models;
using SandBoxAPI.Repositories;

namespace SandBoxAPI.Services
{

    public class WeatherForecastService : Service<WeatherForecast, SandBoxAPIContext, WeatherRepository>
    {
        public IRepository<Region> regionRepository { get; set; }
        public WeatherForecastService(SandBoxAPIContext context, WeatherRepository baseRepository) : base(context, baseRepository) 
        {
            this.regionRepository = new RegionRepository(context);
        }

        public override WeatherForecast Get(int id)
        {
            var weather = base.Get(id);
            weather.Region = this.regionRepository.Get(weather.RegionId ?? 0);

            return weather;
        }
    }
}
