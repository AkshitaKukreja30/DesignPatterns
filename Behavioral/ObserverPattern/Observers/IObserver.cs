namespace DesignPatterns.Behavioral.ObserverPattern.Observers
{
    public interface IObserver
    {
       string Update(float temperature, float humidity);
    }
}
