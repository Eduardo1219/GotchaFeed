using Domain.Gotcha.Repost.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MockData.Reposts
{
    public static class RepostMock
    {
        public static List<RepostEntity> GetRepostMock(Guid postId, Guid userId)
        {
            return new List<RepostEntity>
        {
            new RepostEntity
            {
                Id = Guid.NewGuid(),
                PostId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                RepostDate = DateTime.Now.AddHours(-2),
                RepostContent = "This is the first repost content."
            },
            new RepostEntity
            {
                Id = Guid.NewGuid(),
                PostId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                RepostDate = DateTime.Now.AddDays(-1),
                RepostContent = "Check out this interesting post!"
            },
            new RepostEntity
            {
                Id = Guid.NewGuid(),
                PostId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                RepostDate = DateTime.Now.AddMonths(-1),
                RepostContent = "Reposting this for more visibility."
            },
            new RepostEntity
            {
                Id = Guid.NewGuid(),
                PostId = Guid.NewGuid(),
                UserId = Guid.NewGuid(),
                RepostDate = DateTime.Now.AddYears(-1),
                RepostContent = "Last year's great post!"
            }
        };
        }

    }
}
