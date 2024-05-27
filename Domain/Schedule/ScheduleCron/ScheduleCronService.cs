using Domain.Schedule.Entity;
using Domain.Users.Repository;
using Domain.Users.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Schedule.ScheduleCron
{
    public class ScheduleCronService : IScheduleCronService
    {
        private readonly IUsersService _usersService;
        public ScheduleCronService(IUsersService usersService)
        {
            _usersService = usersService;
        }

        public async Task ResetUsersPostsQnt()
        {
            var users = await _usersService.UsersWithPostsQnt();

            users.ForEach(u =>
            {
                u.ResetPostsDay();
            });

            await _usersService.UpdateManyAsync(users);
        }
    }
}
