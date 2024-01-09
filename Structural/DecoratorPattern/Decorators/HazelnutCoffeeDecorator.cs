using DesignPatterns.Structural.Decorator;

namespace DesignPatterns.Structural.DecoratorPattern.Decorators
{
    public class HazelnutCoffeeDecorator : ICoffee
    {
        private readonly ICoffee _coffee;

        public HazelnutCoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public int Cost()
        {
            return _coffee.Cost() + 50;
        }
    }
}
