﻿using Domain.Post.Repost.Entity;
using GotchaFeed.Controllers.Repost.Dto;

namespace GotchaFeed.Helpers.Mappers
{
    public static class RepostMapper
    {
        public static RepostEntity MapRepost(this RepostPostDto dto)
        {
            return new RepostEntity
            {
                PostId = dto.PostId,
                RepostContent = dto.RepostContent,
                RepostDate = dto.RepostDate,
                UserId = dto.UserId,
            };
        }
    }
}
