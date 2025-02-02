using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers() {
            var map = new Dictionary<string, string>{
                {"application", "User Service"},
                {"version", "0.0.1"},
            };
            return Ok(map);
        }
    }
}