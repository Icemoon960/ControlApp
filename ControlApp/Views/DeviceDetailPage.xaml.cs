using ControlApp.Utilities;

using Xamarin.Forms;

namespace ControlApp.Views
{
    public partial class DeviceDetailPage : CarouselPage
    {
        public DeviceDetailPage()
        {
            BindingContext = ViewModelLocator.OverViewPageViewModel();
            InitializeComponent(); 
        }
    }
}