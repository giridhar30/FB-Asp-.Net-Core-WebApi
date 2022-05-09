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
        }

        public DbSet<FbBackend.Models.User> Users { get; set; }
    }
}
