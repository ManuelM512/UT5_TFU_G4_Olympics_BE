using System.Collections.Generic;
using OlimpiadasApi.Models;

public class ActuacionNotifier : IActuacionNotifier
{
    private readonly List<Func<Actuacion, Task>> _observers = new List<Func<Actuacion, Task>>();

    public void Subscribe(Func<Actuacion, Task> observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(Func<Actuacion, Task> observer)
    {
        _observers.Remove(observer);
    }

    public async void Update(Actuacion performance)
    {
        foreach (var observer in _observers)
        {
            await observer(performance);
        }
    }
}
