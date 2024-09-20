using DesignPatterns.Creational.FactoryPattern.FactoryInterface;

namespace DesignPatterns.Creational.FactoryPattern
{
    public class Client
    {
        private IDeviceFactory _deviceFactory;

        public Client(IDeviceFactory deviceProcessor)
        {
            _deviceFactory = deviceProcessor;
        }

        public void ProcessDevice(string deviceType)
        {
            var device = _deviceFactory.GetDevice(deviceType);
            device.Execute();
        }

    }
}
