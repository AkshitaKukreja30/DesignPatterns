using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractProductInterfaces;

namespace DesignPatterns.Creational.AbstarctFactoryPattern.ConcreteProducts
{
    public class RegularCar : ICar
    {
        public string GetDetails()
        {
            return "I am Regular Car";
        }
    }
}
