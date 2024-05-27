using Domain.Feed.Service;
using Domain.Gotcha.Repost.Service;
using Domain.Gotcha.Service;
using Domain.Users.Service;
using GotchaFeed.Controllers.Repost.Dto;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GotchaFeed.Controllers.Feed.Http
{
    [Route("api/[controller]")]
    [SwaggerTag("Endpoints to manage feed")]
    [Produces("application/json")]
    public class FeedController : Controller
    {
        private readonly IFeedService _feedService;

        public FeedController(IFeedService feedService)
        {
            _feedService = feedService;
        }

        /// <summary>
        /// Get current feed
        /// </summary>
        /// <response code="200">Current feed</response>
        /// <response code="400">Bad Request</response>
        [HttpGet("")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get()
        {
            var currentFeed = await _feedService.GetCurrentFeed();
            currentFeed.Feed = currentFeed.Feed.OrderByDescending(x => x.CreationDate).ToList();

            return StatusCode(StatusCodes.Status200OK, currentFeed);
        }
    }
}
