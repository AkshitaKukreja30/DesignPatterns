using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractFactory;

namespace DesignPatterns.Creational.AbstarctFactoryPattern
{
    public class Client
    {
        private readonly IVehicleFactory _vehicleFactory;

        public Client(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }

        public void OrderVehicle(string type)
        {
            var carType = _vehicleFactory.CreateCar(type);
            carType.GetDetails();

            var bikeType = _vehicleFactory.CreateBike(type);
            bikeType.GetDetails();
        }


    }
}
