using Domain.BaseMongo.Settings;
using Domain.Feed.Entity;
using Domain.Feed.Repository;
using Domain.Gotcha.Repository;
using Infraestructure.Repository.BaseMongo;

namespace Infraestructure.Repository.FeedRepository
{
    public class FeedRepository : MongoRepository<FeedEntity>, IFeedRepository
    {
        private readonly IDatabaseSettings _settings;
        private readonly IGotchaRepository _gotchaRepository;
        public FeedRepository(IDatabaseSettings settings, IGotchaRepository gotchaRepository) : base(settings, gotchaRepository)
        {
            _settings = settings;
            _gotchaRepository = gotchaRepository;
        }
    }
}
