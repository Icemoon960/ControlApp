using ControlApp.CCI.Models.Token;
using ClineControlInterface.Enums;
using ClineControlInterface.Message;
using ClineControlInterface.Models;
using System.Threading;

namespace ControlApp.CCI.CCI_Message
{
    public class CCI_Message : ICCI_Message
    {
        private static int NextMsgId = 0;
        public CCMessageType m_MsgType { get; set; }
        public int m_MsgID { get; set; }
        public ICCMessageToken Token { get; set; }
        public int m_ErrorCode { get; set; }
        public string m_ErrorMessage { get; set; }
        public CCI_Message()
        {
            m_MsgType = CCMessageType.UNDEF;
            Token = new CCMessageToken();
            Interlocked.Increment(ref CCI_Message.NextMsgId);
        }
    }
}
