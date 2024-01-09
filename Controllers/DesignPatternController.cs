using DesignPatterns.AbstarctFactoryPattern.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.DecoratorPattern.Decorators;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers
{
    [ApiController]
    [Route("[patterns]")]
    public class DesignPatternController : ControllerBase
    {
        private readonly ILogger<DesignPatternController> _logger;
        private IDeviceFactory _deviceFactory;
        private IVehicleFactory _vehicleFactory;
        private IDirector _director;
        private ITarget _target;

        private HazelnutCoffeeDecorator _hazelnutCoffeeDecorator;

        public DesignPatternController(ILogger<DesignPatternController> logger)
        {
            _logger = logger;
        }


        [HttpGet, Route("/pattern/factory/{deviceType}", Name = "FactoryApi")]
        public async Task<IActionResult> FactoryPatternClient([FromServices] IDeviceFactory deviceFactory, [FromRoute] string deviceType)
        {
            _deviceFactory = deviceFactory;

            var device = _deviceFactory.GetDevice(deviceType);

            return Ok(device.Execute());
        }


        [HttpGet, Route("/pattern/abstractfactory/{vehicleType}", Name = "AbstractFactory")]
        public async Task<IActionResult> FactoryPatternClient([FromServices] IVehicleFactory deviceFactory, [FromRoute] string vehicleType)
        {
            _vehicleFactory = deviceFactory;

            var carType = _vehicleFactory.CreateCar(vehicleType);
            return Ok(carType.GetDetails());

            //var bikeType = _vehicleFactory.CreateBike(vehicleType);
            //bikeType.GetDetails();

        }


        [HttpGet, Route("/pattern/builder", Name = "Builder")]
        public async Task<IActionResult> FactoryPatternClient([FromServices] IDirector director)
        {
            _director = director;

            _director.BuildHouse();

            return Ok();

        }


        [HttpGet, Route("/pattern/adapter", Name = "Adapter")]
        public async Task<IActionResult> AdapterPatternClient([FromServices] ITarget target)
        {
            _target = target;

            return Ok(_target.GetRequest());
        }


        [HttpGet, Route("/pattern/decorator", Name = "Decorator")]
        public async Task<IActionResult> DecoratorPatternClient([FromServices] HazelnutCoffeeDecorator coffee)
        {
            _hazelnutCoffeeDecorator = coffee;

            return Ok(_hazelnutCoffeeDecorator.Cost());
        }
    }
}