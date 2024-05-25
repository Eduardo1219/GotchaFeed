using Domain.Feed.Entity;
using Domain.Feed.Repository;
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
    public class FeedService : IFeedService
    {
        private readonly IFeedRepository _repository;

        public FeedService(IFeedRepository repository)
        {
            _repository = repository;
        }


        public async  Task UpdateFeed(GotchaEntity gotcha, UsersEntity user)
        {
            var feed = await GetCurrentFeed();
            feed.AddGotcha(gotcha, user);
            await _repository.UpdateAsync(feed);
        }

        public async Task UpdateFeed(RepostEntity repost, GotchaEntity gotcha, UsersEntity user)
        {
            var feed = await GetCurrentFeed();
            feed.AddRepost(repost, gotcha, user);
            await _repository.UpdateAsync(feed);
        }

        private async Task<FeedEntity> GetCurrentFeed()
        {
            var currentFeed = await _repository.GetFirstAsync();
            if (currentFeed != null) return currentFeed;

            return new FeedEntity { Feed = new List<FeedGotcha>() };
        }
    }
}
