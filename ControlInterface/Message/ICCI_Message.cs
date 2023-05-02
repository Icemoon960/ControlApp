using ClineControlInterface.Enums;
using ClineControlInterface.Models;
using JsonSubTypes;

namespace ClineControlInterface.Message
{
    [JsonSubtypes.KnownSubType(typeof(ICCI_Message_DeviceInformation), CCMessageType.XMLError)]
    public interface ICCI_Message
    {
        CCMessageType m_MsgType { get; set; }
        int m_MsgID { get; set; }
        ICCMessageToken Token { get; set; }
        int m_ErrorCode { get; set; }
        string m_ErrorMessage { get; set; }
    }
}
