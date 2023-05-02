using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ControlApp.Utilities;
using ControlApp.ViewModels.Base;
using Xamarin.Forms;

namespace ControlApp.Controls
{
    public sealed class CustomNavigationPage : NavigationPage
    {
        private object _currentNavigationParameter;

        public CustomNavigationPage(string rootViewName, object parameter = null) : base(ViewFactory.GetView(rootViewName))
        {
            _currentNavigationParameter = parameter;
        }
        public async Task PopViewAsync()
        {
            await Navigation.PopAsync(true);
        }
        public async Task PushViewAsync(string rootViewName, object parameter = null)
        {
            _currentNavigationParameter = parameter;
            var view = ViewFactory.GetView(rootViewName);
            await Navigation.PushAsync(view, true);
        }
        public async Task PushModalAsync(string rootViewName, object parameter = null)
        {
            _currentNavigationParameter = parameter;
            var view = ViewFactory.GetView(rootViewName);
            await Navigation.PushModalAsync(view, true);
        }
        public async Task PopModalAsync()
        {
            await Navigation.PopModalAsync(true);
        }
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == nameof(RootPage) && RootPage != null)
            {
                RootPage.Appearing += AppearingHandler;
            }
        }
        private void AppearingHandler(object sender, EventArgs e)
        {
            var viewModel = RootPage.BindingContext as BaseViewModel;
            viewModel?.OnViewPushed(_currentNavigationParameter);
            _currentNavigationParameter = null;
            RootPage.Appearing -= AppearingHandler;
        }
    }
}
