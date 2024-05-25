using Domain.Users.Entity;
using GotchaFeed.Controllers.Users.Dto;

namespace GotchaFeed.Helpers.Mappers
{
    public static class UserMapper
    {
        public static UsersEntity UserDtoMapper(this UserPostDto dto)
        {
            var entity = new UsersEntity
            {
                Active = dto.Active,
                BirthDate = dto.BirthDate,
                Email = dto.Email,
                LastName = dto.LastName,
                Name = dto.Name,
                CreationDate = DateTime.UtcNow.AddHours(-3),
                Nickname = dto.NickName,
                PostsDay = 0
            };
            return entity;
        }
    }
}
