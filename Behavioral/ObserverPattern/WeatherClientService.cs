using DesignPatterns.Behavioral.ObserverPattern.Observers;
using DesignPatterns.Behavioral.ObserverPattern.Subject;

namespace DesignPatterns.Behavioral.ObserverPattern
{
    public class WeatherClientService
    {
        private readonly ISubject _weatherStation;
        private readonly IEnumerable<IObserver> _observers;

        public WeatherClientService(ISubject weatherStation, IEnumerable<IObserver> observers)
        {
            _weatherStation = weatherStation;
            _observers = observers;

            // Register observers
            foreach (var observer in _observers)
            {
                _weatherStation.RegisterObserver(observer);
            }
        }

        public void UpdateWeatherData(float temperature, float humidity)
        {
            // Update the weather data and notify observers
            ((WeatherStation)_weatherStation).SetMeasurements(temperature, humidity);
        }
    }

}
