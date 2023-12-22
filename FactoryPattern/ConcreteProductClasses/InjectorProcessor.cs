namespace DesignPatterns.FactoryPattern
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
