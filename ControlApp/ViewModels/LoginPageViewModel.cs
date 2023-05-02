using ControlApp.ViewModels.Base;
using ControlApp.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControlApp.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public LoginPageViewModel()
        {
            serverip = "10.239.135.244:50405";            
        }
        #region Properties
        private string serverip;
        public string ServerIP
        {
            get
            {
                return serverip;
            }
            private set
            {
                Set(ref serverip, value);
            }
        }
        /*
        private string username;
        public string Username { 
            get { return username; }
            set { Set(ref username, value); }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { Set(ref password, value); }
        }
        */
        #endregion
        #region Navigation
        //public ICommand GoToOverViewPageCommand => GoToCommand(ViewNames.OverViewPage);
        private ICommand GoToCommand(string name) => new Command(() => Navigation.PushAsync(name));
        private ICommand goToOverViewPageCommand;
        public ICommand GoToOverViewPageCommand
        {
            get
            {
                if (goToOverViewPageCommand == null)
                {
                    goToOverViewPageCommand = GoToCommand(ViewNames.OverViewPage);
                }
                return goToOverViewPageCommand;
            }
            set
            {
                Set(ref goToOverViewPageCommand, value);
            }
        }
        #endregion
    }
}
