using Domain.Gotcha.Repost.Entity;
using Domain.Gotcha.Repost.Repository;
using Infraestructure.Context;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository.RepostRepository
{
    public class RepostRepository : BaseRepository<RepostEntity>, IRepostRepository
    {
        private readonly GotchaFeedContext _context;

        public RepostRepository(GotchaFeedContext context) : base(context)
        {
            _context = context;
        }
    }
}
