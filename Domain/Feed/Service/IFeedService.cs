using Domain.Feed.Entity;
using Domain.Gotcha.Entity;
using Domain.Gotcha.Repost.Entity;
using Domain.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Feed.Service
{
    public interface IFeedService
    {
        Task UpdateFeed(GotchaEntity gotcha, UsersEntity user);
        Task UpdateFeed(RepostEntity repost, GotchaEntity gotcha, UsersEntity user);
        Task<FeedEntity> GetCurrentFeed();
    }
}
