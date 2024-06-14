using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;

namespace OlimpiadasApi.Controllers;
// FIXME: Hacer rest decente
[ApiController]
[Route("[controller]")]
public class JudgeController : ControllerBase
{
    private readonly OlympicsContext _dbContext;
    private readonly ILogger<JudgeController> _logger;

    public JudgeController(ILogger<JudgeController> logger, OlympicsContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult Get()
    {
        // Implement your GET logic here
        var users = _dbContext.Jueces.ToList();
        return Ok(users);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Juez jugde)
    {
        // Implement your POST logic here
        return Ok("Funcionó y ahora?");
    }


}