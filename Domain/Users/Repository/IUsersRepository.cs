using Domain.Base.Repository;
using Domain.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Repository
{
    public interface IUsersRepository : IBaseRepository<UsersEntity>
    {
    }
}
