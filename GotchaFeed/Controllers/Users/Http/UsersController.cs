using Domain.Users.Service;
using GotchaFeed.Controllers.Users.Dto;
using GotchaFeed.Helpers.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GotchaFeed.Http.Controllers
{
    [Route("api/[controller]")]
    [SwaggerTag("Endpoints to manage users")]
    [Produces("application/json")]
    public class UsersController : Controller
    {
        private IUsersService _userService;

        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="dto">New User</param>
        /// <response code="201">User sucessfully created</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddUser([FromBody] UserPostDto dto)
        {
            if (!ModelState.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);

            var user = dto.UserDtoMapper();
            await _userService.AddAsync(user);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
