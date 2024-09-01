using assetsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {

        //יצירת נשק
        [HttpPost("/create")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateWeapon([FromBody] weapon weapon)
        {
            var newweapon = await WeaponsServices.createweapon( weapon);
            return Ok(newweapon);
        }

        
    }
}
