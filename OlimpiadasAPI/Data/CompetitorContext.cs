using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;

public class CompetitorContext : DbContext
{
    public DbSet<Competidor> competidores { get; set; }

    public async Task<List<Competidor>?> GetCompetidores()
    {
        return await competidores.ToListAsync();
    }

    public async Task<Competidor?> GetCompetidor(string nombre)
    {
        return await competidores.FirstOrDefaultAsync(c => c.Nombre == nombre);
    }
}