using DesignPatterns.Structural.Bridge.Implementation.Interface;

namespace DesignPatterns.Structural.Bridge.Abstraction.RefinedAbstraction
{
    // Refined Abstraction 2
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public string Mute()
        {
            return "Muting the device";
        }

        public override void SetChannel(int channel)
        {
            device.SetChannel(channel);
        }
    }
}

