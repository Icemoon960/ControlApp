using ControlApp.ViewModels.Base;
using Xamarin.Forms;

namespace ControlApp.Views.Base
{
    public abstract class BaseCarouselPageView<TViewModel> : CarouselPage where TViewModel : BaseViewModel
    {
        protected TViewModel ViewModel { get; }
        protected BaseCarouselPageView()
        {
            ViewModel = CommonServiceLocator.ServiceLocator.Current.GetInstance<TViewModel>();
            BindingContext = ViewModel;
        }
    }
}
