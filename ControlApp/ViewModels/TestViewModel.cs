using ControlApp.ViewModels.Base;
using ControlApp.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControlApp.ViewModels
{
    public class TestViewModel : BaseViewModel
    {
        public TestViewModel()
        {    }
        private ICommand GoToCommand(string name) => new Command(() => Navigation.PushAsync(name));
        public ICommand GoToLogin => GoToCommand(ViewNames.LoginScreenPage);
        public ICommand GoToOverView => GoToCommand(ViewNames.OverViewPage);
        public ICommand GoToDeviceDetail => GoToCommand(ViewNames.DeviceDetailPage);
    }
}
