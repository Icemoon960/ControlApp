using ClineControlInterface.Enums;
using ClineControlInterface.Models;
using System;

namespace ControlApp.ViewModels.Models
{
    public class TemperaturModel : ITemperatur
    {           
        public DateTime? Time { get; set; }        
        public float Temp { get; set; }            
        public SensorType Sensor { get; set; }             
        public SensorState Status { get; set; }
        public TemperaturModel()
        {
            Time = default(DateTime);
            Temp = 0;
            Sensor = SensorType.Default;
            Status = SensorState.BOT;
        }
        public TemperaturModel(ITemperatur iTemp)
        {
            Time = iTemp.Time;
            Temp = iTemp.Temp;
            Sensor = iTemp.Sensor;
            Status = iTemp.Status;
        }
    }
}
