using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformService.DTOs;
using PlatformService.Services.Contracts;
using System.Threading.Tasks;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromForm]CreateUserDTO createUserDTO)
        {
            var user = await _userService.CreateUserAsync(createUserDTO);
            return CreatedAtRoute(nameof(GetUser), new { id = user.Id },  user);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromForm] UpdateUserDTO updateUserDTO)
        {
            return Ok(await _userService.UpdateUserAsync(updateUserDTO));
        }
        [HttpGet("{id}", Name = "GetUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var result = await _userService.DeleteUserAsync(id);

            if(result > 0)
                return Ok();

            return BadRequest();
        }
   
    }
}
