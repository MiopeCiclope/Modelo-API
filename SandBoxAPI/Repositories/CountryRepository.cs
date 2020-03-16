
using Microsoft.EntityFrameworkCore;
using SandBoxAPI.Models;

namespace SandBoxAPI.Repositories
{
    public class CountryRepository : Repository<Country, DbContext>
    {
        public CountryRepository(DbContext context) : base(context) { }
    }
}

