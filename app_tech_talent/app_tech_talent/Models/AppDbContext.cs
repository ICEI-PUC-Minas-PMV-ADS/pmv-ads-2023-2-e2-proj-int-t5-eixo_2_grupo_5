using Microsoft.EntityFrameworkCore;

namespace app_tech_talent.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Curriculo> Curriculos { get; set; }
    }
}
