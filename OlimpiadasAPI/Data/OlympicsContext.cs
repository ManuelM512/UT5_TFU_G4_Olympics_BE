using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;
public class OlympicsContext : DbContext
{
    public DbSet<Juez> Jueces { get; set; }
    public DbSet<Competencia> Competencias { get; set; }
    public DbSet<Competidor> Competidores { get; set; }
    public DbSet<Actuacion> Actuaciones { get; set; }
    public DbSet<PistaNatacion> PistaNatacions { get; set; }
    public DbSet<Halterofilia> Halterofilias { get; set; }
    public DbSet<Esgrima> Esgrimas { get; set; }
    public DbSet<Surf> Surfs { get; set; }
    public DbSet<Kitesurf> Kitesurfs { get; set; }
    public DbSet<GimnasiaClavados> GimnasiaClavadoses { get; set; }
    public DbSet<CompetenciaJuez> CompetenciaJueces { get; set; }
    public DbSet<CompetenciaCompetidor> CompetenciaCompetidores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompetenciaJuez>()
            .HasKey(cj => new { cj.CompetenciaId, cj.JuezId });

        modelBuilder.Entity<CompetenciaCompetidor>()
            .HasKey(cc => new { cc.CompetenciaId, cc.CompetidorId });
    }
}
