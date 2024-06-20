using OlimpiadasApi.Models;

public interface IActuacionNotifier
{
    void Subscribe(Func<Actuacion, Task> observer);
    void Unsubscribe(Func<Actuacion, Task> observer);
    void Update(Actuacion performance);
}
