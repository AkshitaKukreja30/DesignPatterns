using DesignPatterns.AbstarctFactoryPattern;
using DesignPatterns.AbstarctFactoryPattern.AbstractFactory;
using DesignPatterns.AbstarctFactoryPattern.ConcreteFactories;
using DesignPatterns.AbstarctFactoryPattern.ConcreteProducts;
using DesignPatterns.Builder;
using DesignPatterns.Builder.ConcreteBuilders;
using DesignPatterns.FactoryPattern;
using DesignPatterns.FactoryPattern.ConcreteCreatorClasses;
using DesignPatterns.Structural.Adapter;

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


builder.Services.AddTransient<ITarget, MyAdapter>();
builder.Services.AddTransient<ISource,Source>();


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
