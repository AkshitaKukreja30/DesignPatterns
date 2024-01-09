using DesignPatterns.Structural.Decorator;

namespace DesignPatterns.Structural.DecoratorPattern.Decorators
{
    public class CaramelCoffeeDecorator : ICoffee
    {
        private readonly ICoffee _coffee;

        public CaramelCoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public int Cost()
        {
            return _coffee.Cost() + 30;
        }
    }
}
