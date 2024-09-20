using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractProductInterfaces;

namespace DesignPatterns.Creational.AbstarctFactoryPattern.ConcreteProducts
{
    public class RegularBike : IBike
    {
        public string GetDetails()
        {
            return "I am Regular bike";
        }
    }
}
