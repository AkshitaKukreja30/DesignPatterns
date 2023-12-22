using DesignPatterns.AbstarctFactoryPattern.AbstractFactory;
using DesignPatterns.AbstarctFactoryPattern.ConcreteProducts;

namespace DesignPatterns.AbstarctFactoryPattern.ConcreteFactories
{
    public class VehicleFactory : IVehicleFactory
    {
        private readonly Func<string,IBike> _bikeDelegate;
        private readonly Func<string,ICar> _carDelegate;


        public VehicleFactory(Func<string,IBike> bikeDelegate, Func<string,ICar> carDelegate)
        {
            _bikeDelegate = bikeDelegate;
            _carDelegate = carDelegate;
        }

        public IBike CreateBike(string vehicleType)
        {
            return _bikeDelegate(vehicleType);
        }

        public ICar CreateCar(string vehicleType)
        {
            return _carDelegate(vehicleType);
        }
    }
}
