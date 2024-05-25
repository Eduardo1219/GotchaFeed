using Domain.BaseMongo.Settings;
using Domain.Feed.Entity;
using Domain.Feed.Repository;
using Infraestructure.Repository.BaseMongo;

namespace Infraestructure.Repository.FeedRepository
{
    public class FeedRepository : MongoRepository<FeedEntity>, IFeedRepository
    {
        private readonly IDatabaseSettings _settings;
        public FeedRepository(IDatabaseSettings settings) : base(settings)
        {
            _settings = settings;
        }
    }
}
