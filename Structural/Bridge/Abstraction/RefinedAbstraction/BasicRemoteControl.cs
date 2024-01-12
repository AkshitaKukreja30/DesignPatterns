using DesignPatterns.Structural.Bridge.Implementation.Interface;

namespace DesignPatterns.Structural.Bridge.Abstraction.RefinedAbstraction
{
    // Refined Abstraction 1
    public class BasicRemoteControl : RemoteControl
    {
        public BasicRemoteControl(IDevice device) : base(device)
        {
        }

        public override void SetChannel(int channel)
        {
            device.SetChannel(channel);
        }
    }
}
