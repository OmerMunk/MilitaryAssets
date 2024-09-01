using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace assetsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]

    public class soldiersController : ControllerBase
    {
       
        //get all soldiers
        [HttpGet]
        public async Task<IActionResult> GetAllSoldier()
        {
            return Services.GetAllSoldiers();
        }


        // get specific soldier
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSoldierById([FromBody] Guid id)
        {
          return Services.GetSoldierById(id);
        }


        //create soldier
        [HttpPost]
        public async Task<IActionResult> CreateSoldier([FromBody] Soldier soldier)
        {
            return Services.CreateSoldiers;
        }


        //update soldier
        [HttpPut("{id}/update")]
        public async Task<IActionResult> UpdateSoldier([FromBody] Guid id, Soldier soldier)
        {
           return services.UpdateSoldier(id, soldier);
        }


        // update status "delete"
        [HttpPut("{id}/Status")]
        public async Task<IActionResult> ChangeSoldierStatus([FromBody] Guid id, bool status)
        {
            return services.updateStatus(id, status);
        }

    }

}
