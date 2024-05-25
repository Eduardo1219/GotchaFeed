using Domain.Gotcha.Entity;
using GotchaFeed.Controllers.Gotcha.Dto;

namespace GotchaFeed.Helpers.Mappers
{
    public static class GotchaMapper
    {

        public static GotchaEntity MapperGotcha(this GotchaDto dto)
        {
            return new GotchaEntity
            {
                Content = dto.Description,
                RepostQnt = 0,
                UserId = dto.UserId,
                CreationDate = DateTime.UtcNow.AddHours(-3)
            };
        }
    }
}
