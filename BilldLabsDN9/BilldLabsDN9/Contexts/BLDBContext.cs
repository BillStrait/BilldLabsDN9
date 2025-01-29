using BilldLabsDN9.Data.Categories;
using BilldLabsDN9.Data.Models;
using BilldLabsDN9.Data.PostDetails;
using BilldLabsDN9.Data.PostTemplates;
using Microsoft.EntityFrameworkCore;

namespace BilldLabsDN9.Contexts
{
    public class BLDBContext : DbContext
    {

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<ComicReview> ComicReviews { get; set; } = null!;
        public DbSet<Template> Templates { get; set; } = null!;


        public BLDBContext(DbContextOptions<BLDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci");
            base.OnModelCreating(modelBuilder);
        }
    }
}
