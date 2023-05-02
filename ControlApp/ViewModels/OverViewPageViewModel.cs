using ControlApp.CCI.CCI_Message;
using ControlApp.Utilities.Commands;
using ControlApp.ViewModels.Base;
using ControlApp.ViewModels.Models;
using ControlApp.Views;
using ClineControlInterface.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ControlApp.ViewModels
{
    public class OverViewPageViewModel : BaseViewModel
    {
        public async Task<CCI_Message_DeviceInformation> Connect()
        {
            CCI_Message_DeviceInformation msg = new CCI_Message_DeviceInformation();
            //string host = "localhost";
            string host = "10.239.135.244";
            int port = 50505;
            string cci = "api/CCI";
            string scheme = "http";
            int timeout = 1000;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            UriBuilder builder = new UriBuilder(scheme, host, port, cci);
            HttpResponseMessage response = new HttpResponseMessage();
            string json;
            json = JsonConvert.SerializeObject(msg);
            StringContent content = new StringContent(json, Encoding.Unicode, "application/json");
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(timeout);
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));            
            client.DefaultRequestHeaders.Add("Username", Username);
            client.DefaultRequestHeaders.Add("Password", Password);
            var t = await content.ReadAsStringAsync();
            response = await client.PostAsync(builder.Uri, content).ConfigureAwait(true);
            json = await response.Content.ReadAsStringAsync();
            json = Regex.Unescape(json);
            json = json.Remove(0, 1);
            json = json.Remove(json.Length - 1, 1);
            msg = JsonConvert.DeserializeObject<CCI_Message_DeviceInformation>(json);
            Device.BeginInvokeOnMainThread(() => UpdateView(msg));
            return msg;
        }
        public OverViewPageViewModel()
        {
            #region FillDevicesRandomly
            /*
            devices = new ObservableCollection<DeviceInformationModel>();
            Random _rand = new Random();
            Enumerable.Range(1, _rand.Next(5, 20)).ToList().ForEach(d =>
            {
                devices.Add(new DeviceInformationModel()
                {
                    Connection = (int)(_rand.Next(0, 10)) % 2 == 0,
                    ID = (uint)d,
                    Name = "Testname " + d,
                    StorageCapacity = _rand.Next(500, 1000),
                    StorageUse = _rand.Next(100, 500),
                    Temperature = new List<ITemperatur>
                    {
                        new TemperaturModel()
                        {
                            Temp = _rand.Next(0,256) * -1
                        },
                        new TemperaturModel()
                        {
                            Temp = _rand.Next(0,256) * -1
                        },
                        new TemperaturModel()
                        {
                            Temp = _rand.Next(0,256) * -1
                        }
                    }
                });
            });
            */
            #endregion                    
            Connect();
        }
        public void UpdateView(CCI_Message_DeviceInformation msg)
        {
            msg.m_oDeviceInformationList?.ForEach(device => Devices.Add(new DeviceInformationModel(device)));
        }
        public void OnTabed(object sender, EventArgs args)
        {

        }

        private ObservableCollection<DeviceInformationModel> devices;
        public ObservableCollection<DeviceInformationModel> Devices
        {
            get { if (devices == null) { devices = new ObservableCollection<DeviceInformationModel>(); } return devices; }
            set { Set(ref devices, value); }
        }
        private DeviceInformationModel selectedDevice;
        public DeviceInformationModel SelectedDevice
        {
            get { if (selectedDevice == null) { selectedDevice = devices[0]; } return selectedDevice; }
            set { Set(ref selectedDevice, value); }
        }
        #region Navigation  
        private ICommand GoToCommand(string name) => new Command(() => Navigation.PushAsync(name));
        private ICommand goToDetailPageCommand;
        public ICommand GoToDetailPageCommand
        {
            get
            {
                if (goToDetailPageCommand == null)
                {
                    goToDetailPageCommand = new Command<DeviceInformationModel>((DeviceInformationModel device) =>
                    {
                        selectedDevice = device;
                        Navigation.PushAsync(ViewNames.DeviceDetailPage);
                    });
                }
                return goToDetailPageCommand;
            }
            set
            {
                Set(ref goToDetailPageCommand, value);
            }
        }
        #endregion
    }

}
