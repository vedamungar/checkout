using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Service;
using Business.Model;
using Microsoft.AspNetCore.Authorization;

namespace Gateway.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        AuthenticationService userService;
        public AuthenticationController()
        {
            userService = new AuthenticationService();
        }
        [HttpPost]
        public IActionResult Authenticate([FromBody] LoginModel login)
        {
            var token = userService.Authenticate(login.Quadrigram, login.Password);
            if (token != null)
            {
                return Ok(token);
            }
            return Unauthorized(new { message = "Invalid credentials" });

        }
    }
}