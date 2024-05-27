using Domain.Gotcha.Entity;
using Domain.MockData.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MockData.Gotchas
{
    public static class GotchaMock
    {
        public static List<GotchaEntity> GetGotchaMock()
        {
            List<GotchaEntity> gotchas = new List<GotchaEntity>();
            var users = UsersMock.GetMockUsers();

            foreach (var user in users)
            {
                gotchas.Add(new GotchaEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Content = "This is the first gotcha content.",
                    RepostQnt = 0,
                    CreationDate = DateTime.Now.AddHours(-5)
                });

                gotchas.Add(new GotchaEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Content = "Another interesting gotcha!",
                    RepostQnt = 0,
                    CreationDate = DateTime.Now.AddDays(-2)
                });

                gotchas.Add(new GotchaEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Content = "This is the first gotcha content.",
                    RepostQnt = 0,
                    CreationDate = DateTime.Now.AddHours(-5)
                });

                gotchas.Add(new GotchaEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Content = "Yet another gotcha post for you.",
                    RepostQnt = 0,
                    CreationDate = DateTime.Now.AddMonths(-1)
                });

                gotchas.Add(new GotchaEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    Content = "Last but not least, this gotcha!",
                    RepostQnt = 0,
                    CreationDate = DateTime.Now.AddYears(-1)
                });
            }

            return gotchas;
        }
    }
}
