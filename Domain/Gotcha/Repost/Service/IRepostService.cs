﻿using Domain.Gotcha.Repost.Entity;

namespace Domain.Gotcha.Repost.Service
{
    public interface IRepostService
    {
        Task AddAsync(RepostEntity entity);
        Task<RepostEntity> GetRepostByUserIdAndGotchaId(Guid userId, Guid gotchaId);
    }
}
