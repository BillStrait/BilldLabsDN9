using BilldLabsDN9.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BilldLabsDN9.Contexts
{
    public class BLDBContext : DbContext
    {

        public DbSet<User> Users { get; set; } = null!;

        public BLDBContext(DbContextOptions<BLDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
