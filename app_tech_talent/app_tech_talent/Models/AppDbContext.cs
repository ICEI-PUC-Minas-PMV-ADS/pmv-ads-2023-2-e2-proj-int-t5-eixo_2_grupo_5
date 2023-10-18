using Microsoft.EntityFrameworkCore;

namespace app_tech_talent.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
    }
}
