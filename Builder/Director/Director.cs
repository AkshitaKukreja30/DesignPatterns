namespace DesignPatterns.Builder
{
    /// <summary>
    /// Director will direct, state the order and help build the house
    /// </summary>
    public class Director : IDirector
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildHouse()
        {
            _builder.BuildPartA();

            _builder.BuildPartB();

            _builder.BuildPartC();
        }
    }
}
