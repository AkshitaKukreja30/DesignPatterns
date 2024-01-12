using DesignPatterns.Structural.Bridge.Implementation.Interface;

namespace DesignPatterns.Structural.Bridge.Abstraction
{
    // Abstraction
    public abstract class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public virtual string TurnOn()
        {
            return device.TurnOn();
        }

        public virtual string TurnOff()
        {
            return device.TurnOff();
        }

        public abstract void SetChannel(int channel);
    }
}
