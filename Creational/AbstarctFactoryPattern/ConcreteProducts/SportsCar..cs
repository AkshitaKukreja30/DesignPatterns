using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractProductInterfaces;

namespace DesignPatterns.Creational.AbstarctFactoryPattern.ConcreteProducts
{
    public class SportsCar : ICar
    {
        public string GetDetails()
        {
            return "I am Sports Car";
        }
    }
}
