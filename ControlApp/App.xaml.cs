using ClineControlApp.Utilities.Contracts;
using ClineControlApp.Views;
using Xamarin.Forms;

namespace ClineControlApp
{
    public partial class App : Application
    {
        public App(INavigationService navigationService)
        {

            InitializeComponent();
            
            navigationService.SetRootView(ViewNames.TestPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
