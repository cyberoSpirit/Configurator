using System;
using System.Collections.Generic;

namespace CoreUtility
{
    public class SensorsStatus : ISensorsStatus
    {
        public DateTime TimeStamp { get; set; }
        public IEnumerable<SensorData>? SensorData { get; set; } 
    }
}
