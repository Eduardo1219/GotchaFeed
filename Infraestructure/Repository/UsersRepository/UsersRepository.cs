using Domain.Users.Entity;
using Domain.Users.Repository;
using Infraestructure.Context;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository.UsersRepository
{
    public class UsersRepository : BaseRepository<UsersEntity>, IUsersRepository
    {
        private readonly GotchaFeedContext _context;

        public UsersRepository(GotchaFeedContext context) : base(context)
        {
            _context = context;
        }
    }
}
