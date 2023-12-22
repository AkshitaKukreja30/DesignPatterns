namespace DesignPatterns.FactoryPattern
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
