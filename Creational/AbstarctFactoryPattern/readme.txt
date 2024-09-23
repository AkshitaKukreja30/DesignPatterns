Abstract Factory provides an interface for creating families of related/ dependent objects without specifying their concrete classes.
The Abstract Factory is like the blueprint for these factories. 
It doesn't make anything itself, but it tells you which factory to use when you want a specific car type. 
So, if you want a sports car, it tells you to go to the sports car factory; if you want a regular car,
it directs you to the regular car factory. 
Each factory knows exactly how to make the right parts for its car.

Inject AbstractFactory IVehicleFactory in client class.
According to type, Sports or Regular, invoke the Interface ICar , IBike and then that calls the class 
RegularCar/SportsCar on the basis of type

//To Resolve Dependencies at run time as per the DeviceTypes
builder.Services.AddTransient<Func<string, IBike>>(serviceProvider => vehicleType =>
{
    switch (vehicleType)
    {
        case "Regular":
            return serviceProvider.GetService<RegularBike>();
        case "Sports":
            return serviceProvider.GetService<SportsBike>();
        default:
            throw new InvalidOperationException();
    }
});

Client: Main Method of Program Class
Abstract Product A: IBike.cs
Abstract Product B: ICar.cs
ProductA1: RegularBike.cs
ProductB1: SportsBike.cs
ProductA2: RegularCar.cs
ProductB2: SportsCar.cs
Abstract Factory: IVehicleFactory.cs
Concrete Factory: VehicleFactory.cs

Class --> AbstractFactory --> ConcreteFactory --> Abstract Products --> Specific Product