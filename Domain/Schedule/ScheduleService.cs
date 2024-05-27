using Domain.Users.Entity;
using Domain.Users.Service;

namespace Domain.Schedule
{
    public class ScheduleService : ISchedule
    {
        private readonly IUsersService _userService;

        public ScheduleService(IUsersService userService)
        {
            _userService = userService;
        }




        public async Task UpdateLastAccess (UsersEntity user)
        {
            await _userService.UpdateLastAccessAsync(user);
        }

        public async Task IncrementPostsDay(UsersEntity user)
        {
            await _userService.IncrementPostsDay(user);
        }
    }
}
