using SandBoxAPI.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SandBoxAPI.Models
{
    public class Region : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Id")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
