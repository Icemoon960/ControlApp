using System.Threading.Tasks;

namespace ControlApp.Utilities.Contracts
{
    public interface INavigationService
    {
        void SetRootView(string rootViewName, object parameter = null);
        Task PushAsync(string viewName, object parameter = null);
        Task PopAsync();
        Task PushModalAsync(string viewName, object parameter = null);
        Task PopModalAsync();
    }
}
