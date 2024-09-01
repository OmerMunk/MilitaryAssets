using assetsApi.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _vehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Updatevehicle(int id, Vehicle Vehicle)
        {
            if (id == 0)
            {
                return BadRequest(new { message = "No Id found" });
                if (Vehicle == null)
                {
                    return BadRequest(new { message = "Vehicle is null" });
                    bool res = _vehicleService.UpdateHandler(id, Vehicle);

                    if (res) { return StatusCode(StatusCodes.Status200OK); }
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
        }

    }
    
}
   