using ClineControlInterface.Message;
using ClineControlInterface.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlApp.CCI.CCI_Message
{
    public class CCI_Message_Login : CCI_Message, ICCI_Message_Login
    {
        public string m_oUserName { get; set; }
        public uint m_RightsProben { get; set; }
        public uint m_RightsNutzer { get; set; }
        public uint m_RightsFreieFelder { get; set; }
        public uint m_RightsAllgemein { get; set; }
        public uint m_RightsKonfiguration { get; set; }
        public uint m_RightsOrders { get; set; }
        public uint m_oUserId { get; set; }
        public ICCMessageToken OutToken { get; set; }
        public CCI_Message_Login()
        {
            m_oUserName = default(string);
            m_RightsProben = 0;
            m_RightsNutzer = 0;
            m_RightsFreieFelder = 0;
            m_RightsAllgemein = 0;
            m_RightsKonfiguration = 0;
            m_RightsOrders = 0;
            m_oUserId = 0;
        }
    }
}
