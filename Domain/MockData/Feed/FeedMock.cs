using Domain.BaseMongo.Entity;
using Domain.Feed.Entity;
using Domain.Gotcha.Repository;
using Domain.MockData.Gotchas;
using Domain.MockData.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MockData.Feed
{
    public class FeedMock
    {
        public static async Task<T> GetFeedMock<T>(IGotchaRepository gotchaRepository) where T : BaseMongoEntity
        {
            var feedEntity = new FeedEntity{Id=Guid.NewGuid(), Feed = new List<FeedGotcha>()};
            var users = UsersMock.GetMockUsers();

            var gotchaRep = await gotchaRepository.GetAsync(g => true);

            foreach (var gotcha in gotchaRep)
            {
                var user = users.Where(u => u.Id == gotcha.UserId).FirstOrDefault();
                feedEntity.AddGotcha(gotcha, user);
            }

            return feedEntity as T;
        }
    }
}
