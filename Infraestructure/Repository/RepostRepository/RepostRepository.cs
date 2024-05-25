using Domain.Post.Repost.Entity;
using Domain.Post.Repost.Repository;
using Domain.Users.Entity;
using Domain.Users.Repository;
using Infraestructure.Context;
using Infraestructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
