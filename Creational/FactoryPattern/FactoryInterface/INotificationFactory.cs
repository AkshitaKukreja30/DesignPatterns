using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.FactoryInterface
{
    public interface INotificationFactory
    {
        INotificationService CreateNotificationService(string notificationType);
    }
}
