namespace DesignPatterns.FactoryPattern
{
    public interface IDeviceFactory
    {
       IDeviceProcessor  GetDevice(string deviceType);
    }
}
