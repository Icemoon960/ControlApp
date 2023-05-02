using System;

namespace ControlApp.Utilities.Contracts
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}
