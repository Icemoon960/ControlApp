using ControlApp.ViewModels.Base;
using Xamarin.Forms;

namespace ControlApp.Views.Base
{
    public abstract class BaseViewPage<TViewModel> : ContentPage where TViewModel : BaseViewModel
    {
        protected TViewModel ViewModel { get; }
        protected BaseViewPage()
        {
            ViewModel = CommonServiceLocator.ServiceLocator.Current.GetInstance<TViewModel>();            
        }
    }
}
