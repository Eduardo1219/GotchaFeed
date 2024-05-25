using Domain.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Service
{
    public interface IUsersService
    {
        Task AddAsync(UsersEntity users);
        Task<UsersEntity> GetById(Guid id);
    }
}
