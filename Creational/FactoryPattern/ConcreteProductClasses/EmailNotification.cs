using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.ConcreteProductClasses
{
    public class EmailNotification : INotificationService
    {
        public string SendNotification(string message)
        {
            return $"Email Notification: {message}";
        }
    }
}
