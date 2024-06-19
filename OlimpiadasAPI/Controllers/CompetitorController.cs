using Microsoft.AspNetCore.Mvc;

namespace OlimpiadasApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CompetitorController : ControllerBase
{
    private readonly CompetitorFacade _competitorFacade;

    public CompetitorController(CompetitorFacade competitorFacade)
    {
        _competitorFacade = competitorFacade;
    }

    [HttpGet]
    public IActionResult Competidores()
    {
        return Ok(_competitorFacade.GetCompetidores());
    }

    [HttpGet("{nombre}")]
    public IActionResult CompetidorUnico(string nombre)
    {
        return Ok(_competitorFacade.GetCompetidor(nombre));
    }

    [HttpGet("/info/{id}")]
    public IActionResult DatosCompetidor(int id)
    {
        return Ok(_competitorFacade.GetDatosCompetidor(id));
    }
}