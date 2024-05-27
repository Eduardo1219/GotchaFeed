using Domain.Feed.Service;
using Domain.Gotcha.Repost.Service;
using Domain.Gotcha.Service;
using Domain.MockData.Gotchas;
using Domain.MockData.Users;
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
        private readonly IRepostService _repostService;
        private readonly IFeedService _feedService;
        private readonly IGotchaService _gotchaService;

        public ScheduleCronService(IUsersService usersService, IRepostService repostService, IFeedService feedService, IGotchaService gotchaService)
        {
            _usersService = usersService;
            _repostService = repostService;
            _feedService = feedService;
            _gotchaService = gotchaService;
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

        public async Task FeedDatabase()
        {
            var qnt = await _usersService.GetCounAsync();

            if (qnt > 0)
                return;

            var users = UsersMock.GetMockUsers();

            foreach (var user in users)
            {
                await _usersService.AddAsync(user);
                var gotchas = GotchaMock.GetGotchaMock();
                
                foreach(var gotcha in gotchas)
                {
                    await _gotchaService.AddAsync(gotcha);
                }
                
                foreach (var gotcha in gotchas)
                {
                    await _feedService.UpdateFeed(gotcha, user);
                }
            }
        }
    }
}
