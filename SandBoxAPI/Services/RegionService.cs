
using SandBoxAPI.Data;
using SandBoxAPI.Models;
using SandBoxAPI.Repositories;

namespace SandBoxAPI.Services
{

    public class RegionService : Service<Region, SandBoxAPIContext, RegionRepository>
    {
        public RegionService(SandBoxAPIContext context, RegionRepository baseRepository) : base(context, baseRepository) { }
    }
}


