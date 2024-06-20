using Microsoft.AspNetCore.Mvc;

namespace OlimpiadasApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CompetenceController : ControllerBase
{
    private readonly CompetenceContext _competenceContext;

    public CompetenceController(CompetenceContext competenceContext)
    {
        _competenceContext = competenceContext;
    }

    [HttpGet]
    public IActionResult Competencias()
    {
        return Ok(_competenceContext.GetCompetencias());
    }

    [HttpGet("/{id}")]
    public IActionResult CompetenciaUnica(string id)
    {
        return Ok(_competenceContext.GetCompetencia(id));
    }

}