using ControlApp.Utilities;

using Xamarin.Forms;

namespace ControlApp.Views
{
    public partial class LoginScreenPage : ContentPage
    {
        public LoginScreenPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.LoginPageViewModel();
        }
    }
}