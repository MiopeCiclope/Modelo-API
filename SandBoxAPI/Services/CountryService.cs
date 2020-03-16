
using SandBoxAPI.Data;
using SandBoxAPI.Models;
using SandBoxAPI.Repositories;

namespace SandBoxAPI.Services
{

    public class CountryService : Service<Country, SandBoxAPIContext, CountryRepository>
    {
        public CountryService(SandBoxAPIContext context, CountryRepository baseRepository) : base(context, baseRepository) { }
    }
}


