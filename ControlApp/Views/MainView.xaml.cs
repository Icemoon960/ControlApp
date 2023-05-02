using ControlApp.ViewModels;
using ControlApp.Views.Base;

namespace ControlApp.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : BaseMainView
    {                     
        public MainView()
        {
            InitializeComponent();                     
        }
    }
    public abstract class BaseMainView : BaseViewPage<BaseMainViewModel> { }
}
