using ClineControlInterface.Enums;
using ClineControlInterface.Models;
using System;

namespace ControlApp.DataBase.RequestModels
{
    class Temperatur : ITemperatur
    {
        public DateTime? Time { get; set; }
        public float Temp { get; set; }
        public SensorType Sensor { get; set; }
        public SensorState Status { get; set; }
    }
}

