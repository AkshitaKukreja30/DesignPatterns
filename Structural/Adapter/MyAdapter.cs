namespace DesignPatterns.Structural.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface by making conversions/ manipoulations as per the need

    class MyAdapter : ITarget
    {
        private readonly ISource _adaptee;

        public MyAdapter(Source adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is the modifed request. '{ _adaptee.GetSourceRequest()}'. All modifications/ conversions/ adaptations happen here";
        }
    }

}
