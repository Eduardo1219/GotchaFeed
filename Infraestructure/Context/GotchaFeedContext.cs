using Domain.Gotcha.Entity;
using Domain.Gotcha.Repost.Entity;
using Domain.MockData.Gotchas;
using Domain.MockData.Users;
using Domain.Users.Entity;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Infraestructure.Context
{
    public class GotchaFeedContext : DbContext
    {
        public GotchaFeedContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<GotchaEntity> Post { get; set; }
        public DbSet<RepostEntity> Repost { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsersEntity>().HasData(UsersMock.GetMockUsers());
            modelBuilder.Entity<GotchaEntity>().HasData(GotchaMock.GetGotchaMock());
        }
    }
}
