using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.ConcreteProductClasses
{
    /// <summary>
    /// Concrete Product1
    /// </summary>
    public class ScannerProcessor : IDeviceProcessor
    {
        public string Execute()
        {
            return "Scanner";
        }

    }
}
