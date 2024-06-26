﻿using Domain.Gotcha.Repost.Entity;
using GotchaFeed.Controllers.Repost.Dto;

namespace GotchaFeed.Helpers.Mappers
{
    public static class RepostMapper
    {
        public static RepostEntity MapRepost(this RepostPostDto dto)
        {
            return new RepostEntity
            {
                PostId = dto.GotchaId,
                RepostContent = dto.RepostContent,
                RepostDate = DateTime.UtcNow.AddHours(-3),
                UserId = dto.UserId,
            };
        }
    }
}
