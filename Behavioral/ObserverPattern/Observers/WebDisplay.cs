namespace DesignPatterns.Behavioral.ObserverPattern.Observers
{
    public class WebDisplay : IObserver
    {
        public string Update(float temperature, float humidity)
        {
            return ($"WebDisplay - Temperature: {temperature}, Humidity: {humidity}");
        }
    }
}
