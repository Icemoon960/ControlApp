using ControlApp.ViewModels.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControlApp.Controls
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialDeviceCard : ContentView
    {
        public MaterialDeviceCard()
        {
            InitializeComponent();
        }
        #region Properties
        #region ActualCapacityLabel
        public static readonly BindableProperty ActualCapacityLabelTextProperty =
            BindableProperty.Create(
                propertyName: nameof(ActualCapacityLabel),
                returnType: typeof(string),
                declaringType: typeof(MaterialDeviceCard),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: ActualCapacityLabelTextPropertyChanged
            );
        private static void ActualCapacityLabelTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.ActualCapacityLabel.Text = newValue.ToString();
        }
        public string ActualCapacityLabelText
        {
            get
            {
                return (string)GetValue(ActualCapacityLabelTextProperty);
            }

            set
            {
                SetValue(ActualCapacityLabelTextProperty, value);
            }
        }
        #endregion
        #region MaxCapacityLabel
        public static readonly BindableProperty MaxCapacityLabelTextProperty =
            BindableProperty.Create(
                propertyName: nameof(MaxCapacityLabel),
                returnType: typeof(string),
                declaringType: typeof(MaterialDeviceCard),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: MaxCapacityLabelTextPropertyChanged
            );
        private static void MaxCapacityLabelTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.MaxCapacityLabel.Text = newValue.ToString();
        }
        public string MaxCapacityLabelText
        {
            get
            {
                return (string)GetValue(MaxCapacityLabelTextProperty);
            }

            set
            {
                SetValue(MaxCapacityLabelTextProperty, value);
            }
        }
        #endregion
        #region TemperatureLabel
        public static readonly BindableProperty TemperatureLabelTextProperty =
            BindableProperty.Create(
                propertyName: nameof(TemperatureLabel),
                returnType: typeof(string),
                declaringType: typeof(MaterialDeviceCard),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: TemperatureTextPropertyChanged
            );
        private static void TemperatureTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.TemperatureLabel.Text = newValue.ToString();
        }
        public string TemperatureLabelText
        {
            get
            {
                return (string)GetValue(TemperatureLabelTextProperty);
            }

            set
            {
                SetValue(TemperatureLabelTextProperty, value);
            }
        }
        #endregion
        #region DeviceTypeLabel
        public static readonly BindableProperty DeviceTypeLabelTextProperty = 
            BindableProperty.Create(
                propertyName:       nameof(DeviceTypeLabel),
                returnType:         typeof(string),
                declaringType:      typeof(MaterialDeviceCard),
                defaultValue:       default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged:    DeviceTypeTextPropertyChanged
            );
        private static void DeviceTypeTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.DeviceTypeLabel.Text = newValue.ToString();
        }
        public string DeviceTypeLabelText
        {
            get
            {
                return (string)GetValue(DeviceTypeLabelTextProperty);
            }

            set
            {
                SetValue(DeviceTypeLabelTextProperty, value);
            }
        }
        #endregion
        #region DeviceImage
        public static readonly BindableProperty DeviceImageSourceProperty =
            BindableProperty.Create(
                propertyName: nameof(DeviceImage),
                returnType: typeof(string),
                declaringType: typeof(MaterialDeviceCard),
                defaultValue: default(string),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: DeviceImageSourcePropertyChanged
            );
        private static void DeviceImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.DeviceImage.Source = newValue.ToString();
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
        #region CapacityProgressBar
        public static readonly BindableProperty CapacityProgressBarProperty =
            BindableProperty.Create(
                propertyName: nameof(CapacityProgressBar),
                returnType: typeof(double),
                declaringType: typeof(MaterialDeviceCard),
                defaultValue: default(double),
                defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
                propertyChanged: CapacityProgressPropertyChanged
            );
        private static void CapacityProgressPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.CapacityProgressBar.Progress = (double)newValue;
        }
        public double CapacityProgress
        {
            get
            {
                return (double)GetValue(CapacityProgressBarProperty);
            }

            set
            {
                SetValue(CapacityProgressBarProperty, value);
            }
        }
        #endregion
        #region TemperatureProgressBar
        public static readonly BindableProperty TemperatureProgressBarProperty =
           BindableProperty.Create(
               propertyName: nameof(TemperatureProgressBar),
               returnType: typeof(double),
               declaringType: typeof(MaterialDeviceCard),
               defaultValue: default(double),
               defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
               propertyChanged: TemperatureProgressBarPropertyChanged
           );
        private static void TemperatureProgressBarPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.TemperatureProgressBar.Progress = (double)newValue;
        }
        public double TemperatureProgress
        {
            get
            {
                return (double)GetValue(TemperatureProgressBarProperty);
            }

            set
            {
                SetValue(TemperatureProgressBarProperty, value);
            }
        }
        #endregion
        #region ClickCommand
        public static readonly BindableProperty ClickCommandProperty =
           BindableProperty.Create(
               propertyName: nameof(ClickCommand),
               returnType: typeof(ICommand),
               declaringType: typeof(MaterialDeviceCard),
               defaultValue: default(ICommand),
               defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
               propertyChanged: ClickCommandPropertyChanged
           );
        private static void ClickCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.Card.Command = (ICommand)newValue;
        }
        public ICommand ClickCommand
        {
            get
            {
                return (ICommand)GetValue(ClickCommandProperty);
            }

            set
            {
                SetValue(ClickCommandProperty, value);
            }
        }
        #endregion
        #region ClickCommandParameterProperty
        public static readonly BindableProperty ClickCommandParameterProperty =
           BindableProperty.Create(
               propertyName: nameof(ClickCommandParameter),
               returnType: typeof(DeviceInformationModel),
               declaringType: typeof(MaterialDeviceCard),
               defaultValue: default(DeviceInformationModel),
               defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
               propertyChanged: ClickCommandParameterPropertyChanged
           );
        private static void ClickCommandParameterPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;
            control.Card.CommandParameter = (DeviceInformationModel)newValue;
        }
        public DeviceInformationModel ClickCommandParameter
        {
            get
            {
                return (DeviceInformationModel)GetValue(ClickCommandParameterProperty);
            }

            set
            {
                SetValue(ClickCommandParameterProperty, value);
            }
        }
        #endregion
        #region TappedEventHandler
        public static readonly BindableProperty TappedEventHandlerProperty =
           BindableProperty.Create(
               propertyName: nameof(TappedEventHandler),
               returnType: typeof(EventHandler),
               declaringType: typeof(MaterialDeviceCard),
               defaultValue: default(EventHandler),
               defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
               propertyChanged: TappedEventHandlerPropertyChanged
           );
        private static void TappedEventHandlerPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCard)bindable;            
            control.Card.Tapped -= (EventHandler)oldValue;            
            control.Card.Tapped += (EventHandler)newValue;
        }
        public EventHandler TappedEventHandler
        {
            get
            {
                return (EventHandler)GetValue(TappedEventHandlerProperty);
            }

            set
            {
                SetValue(TappedEventHandlerProperty, value);
            }
        }
        #endregion
        #endregion
    }
}