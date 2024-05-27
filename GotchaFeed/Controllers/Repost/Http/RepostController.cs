using Domain.Feed.Service;
using Domain.Gotcha.Repost.Service;
using Domain.Gotcha.Service;
using Domain.Schedule;
using Domain.Users.Service;
using GotchaFeed.Controllers.Repost.Dto;
using GotchaFeed.Helpers.Mappers;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GotchaFeed.Controllers.Repost.Http
{
    [Route("api/[controller]")]
    [SwaggerTag("Endpoints to manage reposts")]
    [Produces("application/json")]
    public class RepostController : Controller
    {
        private IRepostService _service;
        private readonly IGotchaService _gotchaService;
        private readonly IUsersService _usersService;
        private readonly IFeedService _feedService;
        private readonly IRepostService _repostService;

        public RepostController(IRepostService service,
            IGotchaService gotchaService,
            IUsersService usersService,
            IFeedService feedService,
            IRepostService repostService)
        {
            _service = service;
            _gotchaService = gotchaService;
            _usersService = usersService;
            _feedService = feedService;
            _repostService = repostService;
        }

        /// <summary>
        /// Add Repost 
        /// </summary>
        /// <param name="dto">Repost</param>
        /// <response code="201">Repost sucessfully</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddUser([FromBody] RepostPostDto dto)
        {
            if (!ModelState.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);

            var user = await _usersService.GetById(dto.UserId);

            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, "User not found");

            if (user.PostsDay >= 5)
                return StatusCode(StatusCodes.Status400BadRequest, "User reached daily gotcha limit");

            var gotcha = await _gotchaService.GetById(dto.GotchaId);

            if (gotcha == null)
                return StatusCode(StatusCodes.Status400BadRequest, "Gotcha not found");

            var userAlreadyRepost = await _repostService.GetRepostByUserIdAndGotchaId(user.Id, dto.GotchaId);

            if (userAlreadyRepost != null)
                return StatusCode(StatusCodes.Status400BadRequest, "You already repost this gotcha");

            var repost = dto.MapRepost();
            await _service.AddAsync(repost);

            await _feedService.UpdateFeed(repost, gotcha, user);
            BackgroundJob.Enqueue<ISchedule>(s => s.IncrementPostsDay(user));

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
