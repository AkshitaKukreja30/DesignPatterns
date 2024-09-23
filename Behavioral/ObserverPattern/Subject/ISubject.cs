using DesignPatterns.Behavioral.ObserverPattern.Observers;

namespace DesignPatterns.Behavioral.ObserverPattern.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

}
