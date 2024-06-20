using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OlimpiadasApi.Models;

namespace OlimpiadasApi.Controllers;


[ApiController]
[Route("[controller]")]
public class PerformanceController : ControllerBase
{
    private readonly OlympicsContext _dbContext;
     private readonly IActuacionNotifier _notifier;
    private readonly ILogger<PerformanceController> _logger;
    private readonly ActuacionNotifier _liveObserver;

    public PerformanceController(ILogger<PerformanceController> logger, OlympicsContext dbContext, IActuacionNotifier notifier, ActuacionNotifier liveObserver)
    {
        _logger = logger;
        _dbContext = dbContext;
        _notifier = notifier;
        _liveObserver = liveObserver;

    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Actuacion performance)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            _dbContext.Actuaciones.Add(performance);
            await _dbContext.SaveChangesAsync();
            _notifier.Update(performance);
            return Ok("Actuación subida correctamente");
        }
        catch (DbUpdateException)
        {
            return StatusCode(500, "Ocurrió un error al guardar en la base de datos.");
        }
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actuacion>>> Get()
    {
        try
        {
            var actuaciones = await _dbContext.Actuaciones
                .Include(a => a.Competidor)
                .Include(a => a.Competencia)
                .ToListAsync();
            return Ok(actuaciones);
        }
        catch (Exception)
        {
            return StatusCode(500, "Ocurrió un error al recuperar las actuaciones.");
        }
    }

    [HttpGet("live")]
        public async Task Live(CancellationToken cancellationToken)
        {
            var response = Response;
            response.Headers.Add("Content-Type", "text/event-stream");

            var tcs = new TaskCompletionSource();

            Func<Actuacion, Task> onPerformance = async performance =>
            {
                try
                {
                    await response
                        .WriteAsync($"data: {System.Text.Json.JsonSerializer.Serialize(performance)}\n\n");
                    await response.Body.FlushAsync();
                }
                catch (Exception)
                {
                    tcs.SetResult();
                }
            };

            _liveObserver.Subscribe(onPerformance);

            cancellationToken.Register(() =>
            {
                _liveObserver.Unsubscribe(onPerformance);
                tcs.SetResult();
            });

            await tcs.Task;
        }


}