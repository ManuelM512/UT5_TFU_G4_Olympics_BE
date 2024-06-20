using OlimpiadasApi.Models;

public class LoggingActuacionObserver : IActuacionObserver
{
    public void Update(Actuacion performance)
    {
        // Aquí podrías implementar la lógica para manejar la actuación
        // Por ejemplo, registrar un log de la actuación
        Console.WriteLine($"Nueva actuación: {performance.Nombre} del competidor {performance.CompetidorId} en la competencia {performance.CompetenciaId}");
    }
}
