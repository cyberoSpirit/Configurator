using CoreUtility;
using Microsoft.AspNetCore.Mvc;

namespace SensorDataCollector.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensorsStatusController : ControllerBase
    {
        private readonly ILogger<SensorsStatusController> _logger;

        public SensorsStatusController(ILogger<SensorsStatusController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSensorsStatus")]
        public ISensorsStatus Get() => new SensorsStatus()
        {
            TimeStamp = DateTime.Now,
            SensorData = Enumerable.Range(1, Constants.sensorCount).Select(index => new SensorData
            {
                Id = index,
                Temperature = Random.Shared.Next(0, 101)
            })
        };
    }
}
