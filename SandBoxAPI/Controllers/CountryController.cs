
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SandBoxAPI.Models;
using SandBoxAPI.Services;

namespace SandBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : CustomController<Region, RegionService>
    {
        public RegionController(RegionService service, ILogger<RegionController> logger) : base(service, logger) { }
    }
}
