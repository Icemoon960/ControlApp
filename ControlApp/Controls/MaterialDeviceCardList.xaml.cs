using ControlApp.ViewModels.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControlApp.Controls
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialDeviceCardList : ContentView
    {
        public MaterialDeviceCardList()
        {
            InitializeComponent();
        }

        #region Properties
        #region Items
        public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create(
                propertyName: nameof(Items),
                returnType: typeof(ObservableCollection<DeviceInformationModel>),
                declaringType: typeof(MaterialDeviceCardList),
                defaultValue: default(ObservableCollection<DeviceInformationModel>),
                propertyChanged: ItemsChanged,
                defaultBindingMode: BindingMode.TwoWay);
        public ObservableCollection<DeviceInformationModel> Items
        {
            get => (ObservableCollection<DeviceInformationModel>)GetValue(ItemsProperty);
            set => SetValue(ItemsProperty, value);
        }
        public static void ItemsChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCardList)bindable;
            BindableLayout.SetItemsSource(control.CardList, newValue as ObservableCollection<DeviceInformationModel>);
        }
        #endregion
        #region CardClickCommand        
        public static readonly BindableProperty CardClickCommandProperty =
           BindableProperty.Create(
               propertyName: nameof(CardClickCommand),
               returnType: typeof(ICommand),
               declaringType: typeof(MaterialDeviceCardList),
               defaultValue: default(ICommand),
               defaultBindingMode: Xamarin.Forms.BindingMode.TwoWay,
               propertyChanged: ClickCommandPropertyChanged
           );
        private static void ClickCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MaterialDeviceCardList)bindable;
            control.CardClickCommand = (ICommand)newValue;
        }
        public ICommand CardClickCommand
        {
            get
            {
                var a= (ICommand)GetValue(CardClickCommandProperty);
                return a;
            }

            set
            {
                SetValue(CardClickCommandProperty, value);
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
            var control = (MaterialDeviceCardList)bindable;
            control.TappedEventHandler -= (EventHandler)oldValue;
            control.TappedEventHandler += (EventHandler)newValue;
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