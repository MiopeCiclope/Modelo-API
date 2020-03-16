using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Repositories
{
    public class WeatherRepository : Repository<WeatherForecast, DbContext>
    {
        public WeatherRepository(DbContext context) : base(context) { }
    }
}
