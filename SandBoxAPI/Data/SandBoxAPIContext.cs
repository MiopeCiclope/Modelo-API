using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SandBoxAPI;
using SandBoxAPI.Models;

namespace SandBoxAPI.Data
{
    public class SandBoxAPIContext : DbContext
    {
        public SandBoxAPIContext (DbContextOptions<SandBoxAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SandBoxAPI.WeatherForecast> WeatherForecast { get; set; }
    }
}
