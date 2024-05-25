using Domain.Feed.Service;
using Domain.Gotcha.Service;
using Domain.Users.Service;
using GotchaFeed.Controllers.Gotcha.Dto;
using GotchaFeed.Helpers.Mappers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GotchaFeed.Controllers.Gotcha.Http
{
    [Route("api/[controller]")]
    [SwaggerTag("Endpoints to manage gotcha")]
    [Produces("application/json")]
    public class GotchaController : Controller
    {
        private readonly IGotchaService _service;
        private readonly IUsersService _usersService;
        private readonly IFeedService _feedService;

        public GotchaController(IGotchaService service, 
            IUsersService usersService, 
            IFeedService feedService)
        {
            _service = service;
            _usersService = usersService;
            _feedService = feedService;
        }

        /// <summary>
        /// Add a gotcha 
        /// </summary>
        /// <param name="dto">Gotcha dto</param>
        /// <response code="201">Gotcha sucessfully</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddGotcha([FromBody] GotchaDto dto)
        {
            if (!ModelState.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);

            var user = await _usersService.GetById(dto.UserId);

            if (user == null)
                return StatusCode(StatusCodes.Status400BadRequest, "User Not Found");

            var gotcha = dto.MapperGotcha();
            await _service.AddAsync(gotcha);

            await _feedService.UpdateFeed(gotcha, user);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
