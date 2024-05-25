using Domain.Post.Entity;
using Domain.Post.Repository;
using Infraestructure.Context;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository.PostRepository
{
    public class PostRepository : BaseRepository<PostEntity>, IPostRepository
    {
        private readonly GotchaFeedContext _context;

        public PostRepository(GotchaFeedContext context) : base(context)
        {
            _context = context;
        }
    }
}
