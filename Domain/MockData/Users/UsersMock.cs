using Domain.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MockData.Users
{
    public static class UsersMock
    {
        public static List<UsersEntity> GetMockUsers()
        {
            return new List<UsersEntity>()
            {
            new UsersEntity
            {
                Id = Guid.Parse("6cdf691d-db36-4f9d-b567-2173d8431354"),
                Name = "John",
                LastName = "Doe",
                Nickname = "johnny",
                CreationDate = DateTime.Now.AddYears(-2),
                Email = "john.doe@example.com",
                PostsDay = 0,
                Active = true,
                BirthDate = new DateTime(1990, 5, 15),
                LastAccessDate = DateTime.Now,
                ImgBase64 = "6cdf691d-db36-4f9d-b567-2173d8431354.jpg"
            },
            new UsersEntity
            {
                Id = Guid.Parse("fba74d07-310a-4e3a-b689-bb129fbe566f"),
                Name = "Jane",
                LastName = "Smith",
                Nickname = "janeS",
                CreationDate = DateTime.Now.AddYears(-1),
                Email = "jane.smith@example.com",
                PostsDay = 0,
                Active = true,
                BirthDate = new DateTime(1985, 3, 22),
                LastAccessDate = DateTime.Now.AddDays(-1),
                ImgBase64 = "fba74d07-310a-4e3a-b689-bb129fbe566f.jpg"
            },
            new UsersEntity
            {
                Id = Guid.Parse("0e3ee3ef-a250-436b-bae6-754e2685b18c"),
                Name = "Alice",
                LastName = "Johnson",
                Nickname = "aliceJ",
                CreationDate = DateTime.Now.AddMonths(-6),
                Email = "alice.johnson@example.com",
                PostsDay = 0,
                Active = true,
                BirthDate = new DateTime(1992, 8, 10),
                LastAccessDate = DateTime.Now.AddMonths(-1),
                ImgBase64 = "0e3ee3ef-a250-436b-bae6-754e2685b18c.jpg"
            },
            new UsersEntity
            {
                Id = Guid.Parse("b09a4ec4-0cea-45fb-b992-a94208837d29"),
                Name = "Bob",
                LastName = "Brown",
                Nickname = "bobby",
                CreationDate = DateTime.Now.AddYears(-3),
                Email = "bob.brown@example.com",
                PostsDay = 0,
                Active = true,
                BirthDate = new DateTime(1988, 12, 5),
                LastAccessDate = DateTime.Now.AddHours(-5),
                ImgBase64 = "b09a4ec4-0cea-45fb-b992-a94208837d29.jpg"
            }
        };
        }



    }
}
