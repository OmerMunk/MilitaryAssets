using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {






        [HttpGet("{owner_id}")]
        public async Task<IActionResult> GetWeaponByOwner(Guid owner_id)
        {
            var weapon = await GetWeaponByOwner(owner_id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWeapons()
        {
            var AllWeapons = await GetAllWeponsAsync();

            return Ok(AllWeapons);
        }
    }
}
