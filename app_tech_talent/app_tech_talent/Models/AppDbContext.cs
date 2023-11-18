using Microsoft.EntityFrameworkCore;

namespace app_tech_talent.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Habilidades> Habilidades { get; set; }
        public DbSet<Curriculo> Curriculo { get; set; }
        public DbSet<FormacaoAcademica> FormacaoAcademica { get; set; }
        public DbSet<ExperienciaProfissional> ExperienciaProfissional { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
    }
}
