using Domain.Schedule;
using Domain.Users.Entity;
using Domain.Users.Service;
using GotchaFeed.Controllers.Users.Dto;
using GotchaFeed.Helpers.Mappers;
using Hangfire;
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

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="dto">User nickname</param>
        /// <response code="200">User</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("login")]
        [ProducesResponseType(typeof(UsersEntity), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Login([FromBody] UserLoginDto dto)
        {
            if (!ModelState.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);

            var user = await _userService.GetByNickname(dto.NickName);
            if (user == null)
                return StatusCode(StatusCodes.Status400BadRequest, $"User {dto.NickName} not found");

            BackgroundJob.Enqueue<ISchedule>(s => s.UpdateLastAccess(user));

            return StatusCode(StatusCodes.Status200OK, user);
        }
    }
}
