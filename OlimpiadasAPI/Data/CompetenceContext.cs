using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;

public class CompetenceContext : DbContext
{
    public DbSet<Competencia> competencias { get; set; }

    public async Task<List<Competencia>?> GetCompetencias()
    {
        return await competencias.ToListAsync();
    }

    public async Task<Competencia?> GetCompetencia(string id)
    {
        return await competencias.FirstOrDefaultAsync(c => c.Identificador == id);
    }
}