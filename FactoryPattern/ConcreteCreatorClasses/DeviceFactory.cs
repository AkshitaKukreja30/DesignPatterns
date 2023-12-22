namespace DesignPatterns.FactoryPattern.ConcreteCreatorClasses
{
    public class DeviceFactory : IDeviceFactory
    {
        private readonly Func<string, IDeviceProcessor> _deviceProcessorDelegate;

        public DeviceFactory(Func<string,IDeviceProcessor> deviceProcessorDelegate)
        {
            _deviceProcessorDelegate = deviceProcessorDelegate;
        }

        public IDeviceProcessor GetDevice(string deviceType)
        {
            return _deviceProcessorDelegate(deviceType);
        }
    }
}
