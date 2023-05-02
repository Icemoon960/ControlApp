using ControlApp.Utilities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.TestViewModel();
        }
    }
}