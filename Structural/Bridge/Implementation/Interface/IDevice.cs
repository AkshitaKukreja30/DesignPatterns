namespace DesignPatterns.Structural.Bridge.Implementation.Interface
{
    // Implementor interface
    public interface IDevice
    {
        string TurnOn();
        string TurnOff();
        string SetChannel(int channel);
    }
}
