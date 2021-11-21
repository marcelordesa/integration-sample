using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Entities.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace integration_sample_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication userApplication;
        public UserController(IUserApplication _userApplication)
        {
            this.userApplication = _userApplication;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult PostLogin([FromBody] User user)
        {
            try
            {
                var userToken = this.userApplication.GetUserAndToken(user.UserName, user.Password);

                if (userToken == null)
                    return NoContent();

                return Ok(userToken);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}