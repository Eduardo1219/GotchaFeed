using Domain.Post.Entity;
using Domain.Post.Repost.Entity;
using Domain.Users.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Context
{
    public class GotchaFeedContext : DbContext
    {
        public GotchaFeedContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UsersEntity> Users { get; set; }
        public DbSet<PostEntity> Post { get; set; }
        public DbSet<RepostEntity> Repost { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
