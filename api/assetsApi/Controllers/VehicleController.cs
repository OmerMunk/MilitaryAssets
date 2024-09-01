using assetsApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleService _vehicleService;

        public VehicleController(VehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // קבל כל הרכבים
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetAllVehicles()
        {
            return await _VehicleService.Vehicles.ToListAsync();
        }

        // הצג רכב לפי תעודת זהות
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicleById(Guid id)
        {
            Vehicle? vehicle = await this._vehicleService.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }


            return vehicle;
        }


        // הצג רכב לפי לוחית רישוי
        [HttpGet("/LicensePlate{LicensePlate}")]
        public async Task<ActionResult<Vehicle>> GetVehicleByLicensePlate(string LicensePlate)
        {
            Vehicle? vehicle = await this._vehicleService.Vehicles.FindAsync(LicensePlate);
            if (vehicle == null)
            {
                return NotFound();
            }


            return vehicle;
        }
    }
}
