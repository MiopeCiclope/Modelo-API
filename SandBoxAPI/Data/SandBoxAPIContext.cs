using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SandBoxAPI.Models;

namespace SandBoxAPI.Data
{
    public class SandBoxAPIContext : DbContext
    {
        public SandBoxAPIContext (DbContextOptions<SandBoxAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SandBoxAPI.Models.TesteModel> TesteModel { get; set; }
    }
}
