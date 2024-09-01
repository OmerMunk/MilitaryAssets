using assetsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly WeaponsServices _weaponsService;
        public WeaponsController(WeaponsServices weaponsService)
        {
            _weaponsService = weaponsService;
        }
        [HttpGet("units/id")]
        public async Task<IActionResult> SeveralByUnits(Guid guidUnit)
        {
            var weponByUnit = await _weaponsService.GetWeponByUnit(guidUnit);
            return StatusCode(StatusCodes.Status200OK, weponByUnit);
        }
        
    }
}
