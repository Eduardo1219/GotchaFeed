using Domain.BaseMongo.Repository;
using Domain.Feed.Entity;

namespace Domain.Feed.Repository
{
    public interface IFeedRepository : IMongoRepository<FeedEntity>
    {
    }
}
