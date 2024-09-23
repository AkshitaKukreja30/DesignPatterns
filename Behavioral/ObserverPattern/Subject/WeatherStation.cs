using DesignPatterns.Behavioral.ObserverPattern.Observers;

namespace DesignPatterns.Behavioral.ObserverPattern.Subject
{
    
    /// <summary>
    /// This is the subject / observable who notifies if there is a change
    /// </summary>
        public class WeatherStation : ISubject
        {
            private readonly List<IObserver> _observers;
            private float _temperature;
            private float _humidity;

            public WeatherStation()
            {
                _observers = new List<IObserver>();
            }

            public void RegisterObserver(IObserver observer)
            {
                _observers.Add(observer);
            }

            public void RemoveObserver(IObserver observer)
            {
                _observers.Remove(observer);
            }

            public void NotifyObservers()
            {
                foreach (var observer in _observers)
                {
                    observer.Update(_temperature, _humidity);
                }
            }

            public void SetMeasurements(float temperature, float humidity)
            {
                _temperature = temperature;
                _humidity = humidity;
                NotifyObservers();
            }
        }

}
