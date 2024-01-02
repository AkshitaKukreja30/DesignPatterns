namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// The Adaptee contains some useful behavior, but its interface is
    ///  incompatible with the existing client code. The Adaptee needs some
    ///  adaptation before the client code can use it.
    /// </summary>


    public class Source : ISource
    {
        public string GetSourceRequest()
        {
            return "Specific request from Source";
        }
    }
   
}
