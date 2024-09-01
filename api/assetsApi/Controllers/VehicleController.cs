using assetsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _VehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            _VehicleService = vehicleService;
        }

        // קבל כל הרכבים
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetAllVehicle()
        {
            return await _VehicleService.Vehicle.ToListAsync();
        }
    }
}
