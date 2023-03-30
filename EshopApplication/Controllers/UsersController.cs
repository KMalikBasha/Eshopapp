using EshopApplication.Interfaces;
using EshopApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EshopApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _Iusers;
        public UsersController(IUsers users)
        {
            _Iusers = users;
        }
        [HttpGet]
        [Route("getUsers")]
        public IActionResult GetUsers()
        {
            var outData = _Iusers.GetUsersList();
            return Ok(outData);
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult RegisterUser(Users userData)
        {
            var registerData = _Iusers.RegisterUser(userData);
            if(registerData != null)
            {
                return Created("/" + userData.Id, userData);
            }
            else
            {
                return BadRequest();
            }
            
        }

        [HttpPut]
        [Route("UpdateProfile")]
        public IActionResult UpdateUser(Users userData)
        {
            _Iusers.UpdateProfile(userData);
            return Ok(userData);
        }

        [HttpPost]
        [Route("ValidateUser")]
        public IActionResult ValidateUser(LoginUser data)
        {
            var finalResponse = _Iusers.ValidateUser(data);
            if(finalResponse != null)
            {
                return Ok(finalResponse);
            }
            else
            {
                return BadRequest();
            }
           
        }
    }
}
