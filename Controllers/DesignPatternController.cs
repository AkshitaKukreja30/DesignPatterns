using DesignPatterns.AbstarctFactoryPattern.AbstractFactory;
using DesignPatterns.FactoryPattern;
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
        
    }
}