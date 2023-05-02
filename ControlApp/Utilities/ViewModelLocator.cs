using ControlApp.ViewModels;

namespace ControlApp.Utilities
{
    internal static class ViewModelLocator
    {
        public static OverViewPageViewModel OverViewPageViewModel()
        {
            return CommonServiceLocator.ServiceLocator.Current.GetInstance<OverViewPageViewModel>();
        }
        public static LoginPageViewModel LoginPageViewModel()
        {
            return CommonServiceLocator.ServiceLocator.Current.GetInstance<LoginPageViewModel>();
        }
        public static TestViewModel TestViewModel()
        {
            return CommonServiceLocator.ServiceLocator.Current.GetInstance<TestViewModel>();
        }        
    }
    
}
