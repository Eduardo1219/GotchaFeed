using Domain.Users.Entity;

namespace Domain.Schedule
{
    public interface ISchedule
    {
        Task UpdateLastAccess(UsersEntity user);
        Task IncrementPostsDay(UsersEntity user);
    }
}
