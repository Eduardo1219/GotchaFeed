using Domain.Schedule;
using Domain.Users.Entity;
using Domain.Users.Service;
using GotchaFeed.Controllers.Users.Dto;
using GotchaFeed.Helpers.Mappers;
using GotchaFeed.Helpers.MimeHelper;
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

        /// <summary>
        /// Get user picture profile
        /// </summary>
        /// <param name="name">picture name</param>
        /// <response code="200">User</response>
        /// <response code="400">Bad Request</response>
        [HttpGet("image/{name}")]
        public IActionResult GetImage([FromRoute] string name)
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", name.ToUpper());

            if (!System.IO.File.Exists(imagePath))
                return StatusCode(StatusCodes.Status400BadRequest, "Image not found");

            byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);

            string contentType = MimeHelper.ContentTypes[Path.GetExtension(imagePath).ToLower()];

            return File(imageBytes, contentType);
        }
    }
}
