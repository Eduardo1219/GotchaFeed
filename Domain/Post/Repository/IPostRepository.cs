using Domain.Base.Repository;
using Domain.Post.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Post.Repository
{
    public interface IPostRepository : IBaseRepository<PostEntity>
    {
    }
}
