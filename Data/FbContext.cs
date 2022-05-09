using Microsoft.EntityFrameworkCore;
using FbBackend.Models;

namespace FbBackend.Data
{
    public class FbContext : DbContext
    {
        public FbContext(DbContextOptions<FbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<ProfileFriend>().ToTable("ProfileFriend");
        }

        public DbSet<User> User { get; set; }

        public DbSet<ProfileFriend> ProfileFriend { get; set; }

        public DbSet<FbBackend.Models.ProfilePhoto> ProfilePhoto { get; set; }
    }
}
