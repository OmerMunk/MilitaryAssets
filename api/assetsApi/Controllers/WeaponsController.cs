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
            var weponByUnitList = await _weaponsService.GetWeponByUnit(guidUnit);
            if (weponByUnitList == null) { return NotFound(); }
            return StatusCode(StatusCodes.Status200OK, weponByUnitList);
        }
        [HttpGet("activate")]
        public async Task<IActionResult> GetAllActiveWepons()
        {
            var acyiveWeponList = await _weaponsService.GetAllActiveWepons();
            if (acyiveWeponList == null) { return NotFound(); }
            return StatusCode(StatusCodes.Status200OK, acyiveWeponList);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetWeponById(Guid id)
        {
            var weapon = await _weaponsService.GetWeponById(id);
            if (weapon == null) { return NotFound(); }
            return StatusCode(StatusCodes.Status200OK, weapon);
        }
    }
}
