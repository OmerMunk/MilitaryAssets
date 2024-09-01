using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace assetsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Vechiles : ControllerBase
    {
        private readonly VehiclesService _vehiclesService;

        public Vechiles(VehiclesService vehiclesService)
        {
            _vehiclesService = vehiclesService;
        }
        // POST api/<Vechiles>
        [HttpPost]
        public StatusCodeResult Post([FromBody] Vehicle vehicle)
        {
            return _vehiclesService.IsCreated(vehicle) ? StatusCode(StatusCodes.Status201Created) : StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}
