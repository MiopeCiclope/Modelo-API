using SandBoxAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandBoxAPI.Models
{
    public class TesteModel : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
