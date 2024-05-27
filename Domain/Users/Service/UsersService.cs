using Domain.Users.Entity;
using Domain.Users.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users.Service
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repository;

        public UsersService(IUsersRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(UsersEntity users)
        {
            await _repository.AddAsync(users);
        }

        public async Task AddManyAsync(List<UsersEntity> users)
        {
            await _repository.AddManyAsync(users);
        }

        public async Task<UsersEntity> GetById(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<UsersEntity> GetByNickname(string nickname)
        {
            return await _repository.GetFirstAsync(u => u.Nickname.ToLower() == nickname.ToLower());
        }

        public async Task UpdateLastAccessAsync(UsersEntity user)
        {
            user.UpdateLastAccess();
            await _repository.UpdateAsync(user);
        }

        public async Task IncrementPostsDay(UsersEntity user)
        {
            user.IncrementPostsDay();
            await _repository.UpdateAsync(user);
        }

        public async Task<List<UsersEntity>> UsersWithPostsQnt()
        {
            var users = await _repository.GetAsync(u => u.PostsDay > 0);
            return users.ToList();
        }

        public async Task UpdateManyAsync(List<UsersEntity> user)
        {
            await _repository.UpdateManyAsync(user);
        }

        public async Task<int> GetCounAsync()
        {
            var user = await _repository.GetFirstAsync(u => !string.IsNullOrEmpty(u.Name));
            return user  != null ? 1 : 0;
        }
    }
}
