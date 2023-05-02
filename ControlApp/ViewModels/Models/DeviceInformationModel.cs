using ClineControlInterface.Enums;
using ClineControlInterface.Models;
using System.Collections.Generic;

namespace ControlApp.ViewModels.Models
{
    public class DeviceInformationModel : IDeviceInformation
    {
        public string Name { get; set; }
        public uint ID { get; set; }
        public int StorageCapacity { get; set; }
        public int StorageUse { get; set; }
        public DeviceDefinition Typ { get; set; }
        public bool Connection { get; set; }
        public bool Priority { get; set; }
        public int Sucession { get; set; }
        public List<ITemperatur> Temperature { get; set; }
        public Automatic StorageMethod { get; set; }
        public DeviceInformationModel()
        {
            Name = string.Empty;
            ID = 0;
            StorageCapacity = 0;
            StorageUse = 0;
            Typ = DeviceDefinition.Default;
            Connection = false;
            Priority = false;
            Sucession = 0;
            Temperature = new List<ITemperatur>();
            StorageMethod = Automatic.all;        
        }
        public DeviceInformationModel(IDeviceInformation idevice)
        {
            Name = idevice.Name;
            ID = idevice.ID;
            StorageCapacity = idevice.StorageCapacity;
            StorageUse = idevice.StorageUse;
            Typ = idevice.Typ;
            Connection = idevice.Connection;
            Priority = idevice.Priority;
            Sucession = idevice.Sucession;
            StorageMethod = idevice.StorageMethod;
            Temperature = new List<ITemperatur>();
            idevice.Temperature?.ForEach(temp => Temperature.Add(new TemperaturModel(temp)));
            

        }
    }
}
