using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractFactory;
using DesignPatterns.Creational.AbstarctFactoryPattern.AbstractProductInterfaces;
using DesignPatterns.Creational.AbstarctFactoryPattern.ConcreteFactories;
using DesignPatterns.Creational.AbstarctFactoryPattern.ConcreteProducts;
using DesignPatterns.Creational.Builder.BuilderInterface;
using DesignPatterns.Creational.Builder.ConcreteBuilders;
using DesignPatterns.Creational.Builder.Director;
using DesignPatterns.Creational.FactoryPattern.ConcreteCreatorClasses;
using DesignPatterns.Creational.FactoryPattern.ConcreteProductClasses;
using DesignPatterns.Creational.FactoryPattern.FactoryInterface;
using DesignPatterns.Creational.FactoryPattern.ProductInterface;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge.Abstraction;
using DesignPatterns.Structural.Bridge.Abstraction.RefinedAbstraction;
using DesignPatterns.Structural.Bridge.Implementation.ConcreteImplementors;
using DesignPatterns.Structural.Bridge.Implementation.Interface;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Decorator.Concrete.BaseComponent;
using DesignPatterns.Structural.DecoratorPattern.Decorators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDeviceFactory, DeviceFactory>();
builder.Services.AddTransient<ScannerProcessor>();
builder.Services.AddTransient<InjectorProcessor>();

//To Resolve Dependencies at run time as per the DeviceTypes
builder.Services.AddTransient<Func<string, IDeviceProcessor>>(serviceProvider => deviceType =>
{
    switch (deviceType)
    {
        case "Scanner":
            return serviceProvider.GetService<ScannerProcessor>();
        case "Injector":
            return serviceProvider.GetService<InjectorProcessor>();
        default:
            throw new InvalidOperationException();
    }
});


builder.Services.AddTransient<IVehicleFactory, VehicleFactory>();
builder.Services.AddTransient<RegularBike>();
builder.Services.AddTransient<RegularCar>();
builder.Services.AddTransient<SportsBike>();
builder.Services.AddTransient<SportsCar>();


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

//To Resolve Dependencies at run time as per the DeviceTypes
builder.Services.AddTransient<Func<string, ICar>>(serviceProvider => vehicleType =>
{
    switch (vehicleType)
    {
        case "Regular":
            return serviceProvider.GetService<RegularCar>();
        case "Sports":
            return serviceProvider.GetService<SportsCar>();
        default:
            throw new InvalidOperationException();
    }
});

builder.Services.AddTransient<IBuilder, LuxuryHouse>();
builder.Services.AddTransient<IDirector, Director>();

builder.Services.AddTransient<ICoffee, SimpleCoffee>();
builder.Services.AddTransient<HazelnutCoffeeDecorator>();
builder.Services.AddTransient<CaramelCoffeeDecorator>();

builder.Services.AddTransient<ISource, Source>();
builder.Services.AddTransient<ITarget, MyAdapter>();

builder.Services.AddTransient<IDevice, TV>();
builder.Services.AddTransient<AdvancedRemoteControl>();
builder.Services.AddTransient<BasicRemoteControl>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
