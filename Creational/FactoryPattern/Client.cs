using DesignPatterns.Creational.FactoryPattern.FactoryInterface;

namespace DesignPatterns.Creational.FactoryPattern
{
    public class Client
    {
        private IDeviceFactory _deviceFactory;
        private INotificationFactory _notificationFactory;  

        public Client(IDeviceFactory deviceProcessor, INotificationFactory notificationFactory)
        {
            _deviceFactory = deviceProcessor;
            _notificationFactory = notificationFactory;
        }

        public void ProcessDevice(string deviceType)
        {
            var device = _deviceFactory.GetDevice(deviceType);
            device.Execute();
        }

        public void SendNotifications(string notificationType)
        {
            var notificationObj = _notificationFactory.CreateNotificationService(notificationType);
            notificationObj.SendNotification("HEYYYY");
        }

    }
}
