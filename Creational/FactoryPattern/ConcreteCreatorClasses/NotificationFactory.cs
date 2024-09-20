using DesignPatterns.Creational.FactoryPattern.ConcreteProductClasses;
using DesignPatterns.Creational.FactoryPattern.FactoryInterface;
using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.ConcreteCreatorClasses
{
    public class NotificationFactory : INotificationFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public INotificationService CreateNotificationService(string notificationType)
        {
            switch (notificationType)
            {
                case "SMS": return _serviceProvider.GetService<SmsNotification>();
                case "Email": return _serviceProvider.GetService<EmailNotification>();
                default:
                    throw new ArgumentException("Invalid notification type");

            }
        }
    }
}
