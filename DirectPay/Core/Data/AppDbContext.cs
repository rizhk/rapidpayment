using Microsoft.EntityFrameworkCore;
using DirectPay.Core.Models;  // Adjust if your models namespace is different

namespace DirectPay.Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add your DbSets here (examples)
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }
        // Add more as needed...

        // Optional: override OnModelCreating for configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API configurations if needed
            base.OnModelCreating(modelBuilder);
        }
    }
}