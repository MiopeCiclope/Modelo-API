
using Microsoft.EntityFrameworkCore;
using SandBoxAPI.Models;

namespace SandBoxAPI.Repositories
{
    public class RegionRepository : Repository<Region, DbContext>
    {
        public RegionRepository(DbContext context) : base(context) { }
    }
}

