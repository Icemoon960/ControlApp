using ClineControlInterface.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClineControlInterface.Message
{
    public interface ICCI_Message_Login : ICCI_Message
    {
        string m_oUserName { get; set; }
        uint m_RightsProben { get; set; }
        uint m_RightsNutzer { get; set; }
        uint m_RightsFreieFelder { get; set; }
        uint m_RightsAllgemein { get; set; }
        uint m_RightsKonfiguration { get; set; }
        uint m_RightsOrders { get; set; }
        uint m_oUserId { get; set; }
        ICCMessageToken OutToken { get; set; }
    }
}
