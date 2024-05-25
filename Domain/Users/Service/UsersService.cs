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

        public async Task<UsersEntity> GetById(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
