using DesignPatterns.Structural.Bridge.Implementation.Interface;

namespace DesignPatterns.Structural.Bridge.Implementation.ConcreteImplementors
{

    // Concrete Implementor 1
    public class TV : IDevice
    {
        public string TurnOn()
        {
            return "TV is turned on";
        }

        public string TurnOff()
        {
            return "TV is turned off";
        }

        public string SetChannel(int channel)
        {
            return $"TV channel set to {channel}";
        }
    }

}
