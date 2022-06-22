using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return Ok(await _userService.GetUsers());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]User user)
        {
            await _userService.SaveUser(user);
            return Ok();
        }
    }
}
