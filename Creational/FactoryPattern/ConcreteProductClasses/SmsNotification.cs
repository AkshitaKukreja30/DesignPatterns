using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.ConcreteProductClasses
{
        public class SmsNotification : INotificationService
        {
            public string SendNotification(string message)
            {
                return $"SMS Notification: {message}";
            }
        }
}
