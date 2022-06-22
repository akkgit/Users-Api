using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using Users.Dto;

namespace Users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return Ok(await _userService.GetUsers());
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateUserDto createUser)
        {
            await _userService.SaveUser(_mapper.Map<User>(createUser));
            return Ok();
        }
    }
}
