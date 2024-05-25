using Domain.Gotcha.Entity;
using GotchaFeed.Controllers.Gotcha.Dto;

namespace GotchaFeed.Helpers.Mappers
{
    public static class GotchaMapper
    {

        public static GotchaEntity MapperPost(this GotchaDto dto)
        {
            return new GotchaEntity
            {
                Description = dto.Description,
                RepostQnt = 0,
                UserId = dto.UserId,
                PostDate = DateTime.UtcNow.AddHours(-3)
            };
        }
    }
}
