using ControlApp.CCI.Converters;
using ControlApp.DataBase.RequestModels;
using ClineControlInterface.Enums;
using ClineControlInterface.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ControlApp.CCI.DataBase.RequestModels
{
    public class DeviceInformation : IDeviceInformation
    {
        public string Name { get; set; }
        public uint ID { get; set; }
        public int StorageCapacity { get; set; }
        public int StorageUse { get; set; }
        public DeviceDefinition Typ { get; set; }
        public bool Connection { get; set; }
        public bool Priority { get; set; }
        public int Sucession { get; set; }
        [JsonProperty(ItemConverterType = typeof(ConcreteTypeConverter<Temperatur>))]
        public List<ITemperatur> Temperature { get; set; }
        public Automatic StorageMethod { get; set; }
        
    }
}
