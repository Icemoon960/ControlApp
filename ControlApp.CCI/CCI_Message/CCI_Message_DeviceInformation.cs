using ControlApp.CCI.Converters;
using ControlApp.CCI.DataBase.RequestModels;
using ClineControlInterface.Enums;
using ClineControlInterface.Message;
using ClineControlInterface.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ControlApp.CCI.CCI_Message
{
    public class CCI_Message_DeviceInformation : CCI_Message, ICCI_Message_DeviceInformation
    {
        [JsonProperty(ItemConverterType = typeof(ConcreteTypeConverter<DeviceInformation>))]
        public List<IDeviceInformation> m_oDeviceInformationList { get; set; }
        public CCI_Message_DeviceInformation()
        {
            m_MsgType = CCMessageType.CCIDeviceInformation;
            m_oDeviceInformationList = new List<IDeviceInformation>();             
        }        
    }
}
