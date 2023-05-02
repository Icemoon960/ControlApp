using ClineControlInterface.Enums;
using System.Collections.Generic;

namespace ClineControlInterface.Models
{
    public interface IDeviceInformation
    {
        string Name { get; set; }
        uint ID { get; set; }
        int StorageCapacity { get; set; }
        int StorageUse { get; set; }
        DeviceDefinition Typ { get; set; }
        bool Connection { get; set; }
        bool Priority { get; set; }
        int Sucession { get; set; }
        List<ITemperatur> Temperature { get; set; }
        Automatic StorageMethod { get; set; }
    }
}
