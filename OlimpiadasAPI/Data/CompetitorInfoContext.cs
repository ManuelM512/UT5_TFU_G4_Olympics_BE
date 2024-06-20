using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;

public class CompetitorInfoContext : DbContext
{
    public DbSet<DatosCompetidor> datosCompetidores { get; set; }

    public async Task<DatosCompetidor?> GetDatosCompetidor(int id)
    {
        return await datosCompetidores.FirstOrDefaultAsync(dc => dc.Id == id);
    }
}