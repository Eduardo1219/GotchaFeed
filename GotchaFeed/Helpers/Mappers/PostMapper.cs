using Domain.Post.Entity;
using GotchaFeed.Controllers.Posts.Dto;

namespace GotchaFeed.Helpers.Mappers
{
    public static class PostMapper
    {

        public static PostEntity MapperPost(this PostsDto dto)
        {
            return new PostEntity
            {
                Description = dto.Description,
                RepostQnt = 0,
                UserId = dto.UserId,
                PostDate = DateTime.UtcNow.AddHours(-3)
            };
        }
    }
}
