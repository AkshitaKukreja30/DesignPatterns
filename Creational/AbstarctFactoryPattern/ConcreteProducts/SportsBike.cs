using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractProductInterfaces;

namespace DesignPatterns.Creational.AbstarctFactoryPattern.ConcreteProducts
{
    public class SportsBike : IBike
    {
        public string GetDetails()
        {
            return "I am SportsBike";
        }
    }
}
