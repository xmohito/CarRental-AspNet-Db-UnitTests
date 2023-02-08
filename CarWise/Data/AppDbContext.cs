using Microsoft.EntityFrameworkCore;

namespace CarWise.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Models.Users> Users { get; set; } = default!;
    }
}
