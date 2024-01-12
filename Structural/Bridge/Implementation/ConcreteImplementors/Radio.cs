using DesignPatterns.Structural.Bridge.Implementation.Interface;

namespace DesignPatterns.Structural.Bridge.Implementation.ConcreteImplementors
{
    // Concrete Implementor 2
    public class Radio : IDevice
    {
        public string TurnOn()
        {
            return "Radio is turned on";
        }

        public string TurnOff()
        {
            return "Radio is turned off";
        }

        public string SetChannel(int channel)
        {
            return $"Radio frequency set to {channel}";
        }
    }
}
