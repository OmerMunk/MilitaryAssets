using assetsApi.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
      

        [HttpPut("{id}")]
        public async Task<ActionResult> Updatevehicle(Vehicle Vehicle)
        {
           
                return BadRequest(new { message = "No Id found" });
            if (Vehicle == null)
            {
                return BadRequest(new { message = "Vehicle is null" });
            }
                    bool res = await _CarsService.UpdateVehicle(Vehicle);

                    if (res) { return StatusCode(StatusCodes.Status200OK); }
                    return StatusCode(StatusCodes.Status400BadRequest);
                
            
        }
        [HttpGet("{Model}")]
        public async Task<List<Vehicle>> ActionResult()
        {

           return await _Carsservice.GetAllbyModel(Model);
        }

    }
    
}
   