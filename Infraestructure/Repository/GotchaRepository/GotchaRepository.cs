using Domain.Gotcha.Entity;
using Domain.Gotcha.Repository;
using Infraestructure.Context;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository.PostRepository
{
    public class GotchaRepository : BaseRepository<GotchaEntity>, IGotchaRepository
    {
        private readonly GotchaFeedContext _context;

        public GotchaRepository(GotchaFeedContext context) : base(context)
        {
            _context = context;
        }
    }
}
