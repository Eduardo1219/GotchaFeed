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
        Task AddManyAsync(List<UsersEntity> users);
        Task<UsersEntity> GetById(Guid id);
        Task<UsersEntity> GetByNickname(string nickname);
        Task UpdateLastAccessAsync(UsersEntity user);
        Task IncrementPostsDay(UsersEntity user);
        Task<List<UsersEntity>> UsersWithPostsQnt();
        Task UpdateManyAsync(List<UsersEntity> user);
        Task<int> GetCounAsync();
    }
}
