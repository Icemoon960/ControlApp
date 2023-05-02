using ControlApp.Utilities;
using Xamarin.Forms;

namespace ControlApp.Views
{
    public partial class OverViewPage : ContentPage
    {
        public OverViewPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.OverViewPageViewModel();
        }
    }
}