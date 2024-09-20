using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.FactoryInterface
{
    public interface IDeviceFactory
    {
        IDeviceProcessor GetDevice(string deviceType);
    }
}
