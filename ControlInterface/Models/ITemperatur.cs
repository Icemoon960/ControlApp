using ClineControlInterface.Enums;
using System;

namespace ClineControlInterface.Models
{
    public interface ITemperatur
    {
        DateTime? Time { get; set; }
        float Temp { get; set; }
        SensorType Sensor { get; set; }
        SensorState Status { get; set; }
    }
}
