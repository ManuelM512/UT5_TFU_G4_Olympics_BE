using Microsoft.AspNetCore.Mvc;
using OlimpiadasApi.Models;

public class CompetitorFacade
{
    private readonly CompetitorContext _competitorContext;
    private readonly CompetitorInfoContext _competitorInfoContext;

    public CompetitorFacade(CompetitorContext competitorContext, CompetitorInfoContext competitorInfoContext)
    {
        _competitorContext = competitorContext;
        _competitorInfoContext = competitorInfoContext;
    }

    public async Task<List<Competidor>?> GetCompetidores()
    {
        return await _competitorContext.GetCompetidores();
    }

    public async Task<DatosCompetidor?> GetDatosCompetidor(int idCompetidor)
    {
        return await _competitorInfoContext.GetDatosCompetidor(idCompetidor);
    }

    public async Task<Competidor?> GetCompetidor(string nombre)
    {
        return await _competitorContext.GetCompetidor(nombre);
    }
}