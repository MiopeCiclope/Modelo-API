using Microsoft.EntityFrameworkCore;

namespace SandBoxAPI.Repositories
{
    public class WeatherRepository : Repository<WeatherForecast, DbContext>
    {
        public WeatherRepository(DbContext context) : base(context) { }
    }
}
