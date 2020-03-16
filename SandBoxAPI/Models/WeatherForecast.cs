using SandBoxAPI.Interfaces;
using SandBoxAPI.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SandBoxAPI
{
    public class WeatherForecast : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }
        [ForeignKey("Id")]
        public int? RegionId { get; set; }

        public Region? Region { get; set; }
    }
}
