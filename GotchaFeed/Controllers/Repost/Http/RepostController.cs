using Domain.Gotcha.Repost.Service;
using GotchaFeed.Controllers.Repost.Dto;
using GotchaFeed.Helpers.Mappers;
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

        public RepostController(IRepostService repostService)
        {
            _service = repostService;
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

            var repost = dto.MapRepost();
            await _service.AddAsync(repost);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
