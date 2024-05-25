using Domain.Base.Repository;
using Domain.Post.Repost.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Post.Repost.Repository
{
    public interface IRepostRepository : IBaseRepository<RepostEntity>
    {
    }
}