using Domain.Post.Repost.Service;
using Domain.Post.Service;
using GotchaFeed.Controllers.Posts.Dto;
using GotchaFeed.Controllers.Repost.Dto;
using GotchaFeed.Helpers.Mappers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace GotchaFeed.Controllers.Posts.Http
{
    [Route("api/[controller]")]
    [SwaggerTag("Endpoints to manage posts")]
    [Produces("application/json")]
    public class PostsController : Controller
    {
        private IPostService _service;

        public PostsController(IPostService postService)
        {
            _service = postService;
        }

        /// <summary>
        /// Add a post 
        /// </summary>
        /// <param name="dto">post dto</param>
        /// <response code="201">post sucessfully</response>
        /// <response code="400">Bad Request</response>
        [HttpPost("")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddUser([FromBody] PostsDto dto)
        {
            if (!ModelState.IsValid)
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);

            var posts = dto.MapperPost();
            await _service.AddAsync(posts);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
