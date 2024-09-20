using DesignPatterns.Creational.FactoryPattern.ProductInterface;

namespace DesignPatterns.Creational.FactoryPattern.ConcreteProductClasses
{
    /// <summary>
    /// Concrete Product2
    /// </summary>
    public class InjectorProcessor : IDeviceProcessor
    {
        public string Execute()
        {
            return "Injector";
        }
    }
}
