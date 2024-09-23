namespace DesignPatterns.Behavioral.ObserverPattern.Observers
{
   
        public class PhoneDisplay : IObserver
        {
            public string Update(float temperature, float humidity)
            {
                return ($"PhoneDisplay - Temperature: {temperature}, Humidity: {humidity}");
            }
        }
}
