
using Xamarin.Forms;

namespace ControlApp.Controls
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDetailView : ContentView
    {
        public DeviceDetailView()
        {
            InitializeComponent();
        }
        #region Properties
        #region DeviceName
        public static readonly BindableProperty DeviceNameTextProperty =
            BindableProperty.Create(
                propertyName: nameof(DeviceNameLabel),
                returnType: typeof(string),
                declaringType: typeof(DeviceDetailView),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: DeviceNameTextPropertyChanged
            );
        private static void DeviceNameTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DeviceDetailView)bindable;
            control.DeviceNameLabel.Text = (string)newValue;
        }
        public string DeviceNameText
        {
            get
            {
                return (string)GetValue(DeviceNameTextProperty);
            }

            set
            {
                SetValue(DeviceNameTextProperty, value);
            }
        }
        #endregion
        #region DeviceImage
        public static readonly BindableProperty DeviceImageSourceProperty =
            BindableProperty.Create(
                propertyName: nameof(DeviceImage),
                returnType: typeof(string),
                declaringType: typeof(DeviceDetailView),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: DeviceImageSourcePropertyChanged
            );
        private static void DeviceImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DeviceDetailView)bindable;
            control.DeviceImage.Source = (string)newValue;
        }
        public string DeviceImageSource
        {
            get
            {
                return (string)GetValue(DeviceImageSourceProperty);
            }

            set
            {
                SetValue(DeviceImageSourceProperty, value);
            }
        }
        #endregion
        #region DeviceType
        public static readonly BindableProperty DeviceTypeTextProperty =
            BindableProperty.Create(
                propertyName: nameof(DeviceTypeLabel),
                returnType: typeof(string),
                declaringType: typeof(DeviceDetailView),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: DeviceTypeTextPropertyChanged
            );
        private static void DeviceTypeTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DeviceDetailView)bindable;
            control.DeviceTypeLabel.Text = (string)newValue;
        }
        public string DeviceTypeText
        {
            get
            {
                return (string)GetValue(DeviceTypeTextProperty);
            }

            set
            {
                SetValue(DeviceTypeTextProperty, value);
            }
        }
        #endregion
        #region OnlineState
        public static readonly BindableProperty OnlineStateProperty =
            BindableProperty.Create(
                propertyName: nameof(OnlineStateCheckBox),
                returnType: typeof(bool),
                declaringType: typeof(DeviceDetailView),
                defaultValue: default(bool),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: OnlineStatePropertyChanged
            );
        private static void OnlineStatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DeviceDetailView)bindable;
            control.OnlineStateCheckBox.IsChecked = (bool)newValue;
        }
        public bool OnlineState
        {
            get
            {
                return (bool)GetValue(OnlineStateProperty);
            }

            set
            {
                SetValue(OnlineStateProperty, value);
            }
        }
        #endregion
        #region OnlineStateText
        public static readonly BindableProperty OnlineStateTextProperty =
            BindableProperty.Create(
                propertyName: nameof(OnlineStateLabel),
                returnType: typeof(string),
                declaringType: typeof(DeviceDetailView),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: OnlineStateTextPropertyChanged
            );
        private static void OnlineStateTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DeviceDetailView)bindable;
            control.OnlineStateLabel.Text = (string)newValue;
        }
        public string OnlineStateText
        {
            get
            {
                return (string)GetValue(OnlineStateTextProperty);
            }

            set
            {
                SetValue(OnlineStateTextProperty, value);
            }
        }
        #endregion
        #endregion
    }
}