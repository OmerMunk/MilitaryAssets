using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace assetsApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        
        private readonly UserServic _userservic;

        public AdminController(UserServic ServicUser)
        {

            _userservic = ServicUser;
        }
        
        [HttpPost]
        public async Task< IActionResult> AddAdmin(Users user)
        {

            if (user == null)
            {

                return BadRequest();

            }
            bool result =   await _userservic.CheckUserBool(user);
            if (!result)
            {
                await _userservic.CreateUser(user);
                return StatusCode(StatusCodes.Status201Created, new { messege = "User registered successfully" });
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest, new { erorr_messege = "You are already registered in the system " });
            }  

        }


    }
}
