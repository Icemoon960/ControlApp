using ClineControlInterface.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClineControlInterface.Message
{
    public interface ICCI_Message_DeviceInformation : ICCI_Message
    {
        List<IDeviceInformation> m_oDeviceInformationList { get; set; } 
    }
}
