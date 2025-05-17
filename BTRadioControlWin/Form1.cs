using System;
using System.Configuration;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Radios;

namespace BTRadioControl
{
    public partial class BTRadioControlForm : Form
    {
        public BTRadioControlForm()
        {
            InitializeComponent();
        }

        /*
         https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.devices.radios/radio_fromidasync_1322863552.md

         A static method that retrieves a Radio object. The method accepts the 'Device.Id' found through Windows.Devices.Enumeration.DeviceInformation.FindAllAsync. 
         This procedure is more reliable than using GetRadiosAsync to obtain a radio in situations where a USB Radio has failed or been removed on a Windows 10 workstation. 
         In this instance of a failed or removed radio, GetRadiosAsync returns no bluetooth radio. FindAllAsync, in contrast, returns a valid Id that can be passed to FromIdAsync 
         to obtain the radio object, which will report itself as now being in the state of 'Disabled'.
        */

        private void Log(String s)
        {
            txtLog.Invoke((MethodInvoker)delegate
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(txtLog.Text);
                sb.AppendLine(s);

                txtLog.Text = sb.ToString();
            });
        }        

        private async void BTRadioControlForm_Load(object sender, EventArgs e)
        {
            Log("List Devices, edit App.config and set the ID to the one that looks like SWD#RADIO ... ");
            Log($"Command Line is [ {Environment.CommandLine} ]");

            await Task.Run(async () =>
            {
                var accessLevel = await Radio.RequestAccessAsync();

                if (accessLevel == RadioAccessStatus.Allowed)
                {
                    Log("Radio Acces OK");
                }
                else
                {
                    Log("Radio Acces KO");
                }
            });
        }

        private async void btnOFF_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var radbt = await Radio.FromIdAsync(ConfigurationManager.AppSettings["BTDeviceId"]);
                await radbt.SetStateAsync(RadioState.Off);
            });
        }

        private async void btnON_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var radbt = await Radio.FromIdAsync(ConfigurationManager.AppSettings["BTDeviceId"]);
                await radbt.SetStateAsync(RadioState.On);
            });
        }

        private async void btnListDevices_Click(object sender, EventArgs e)
        {
            var radiosf = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < radiosf.Count; i++)
            {
                var rad = radiosf[i];
                sb.AppendLine($"{rad.Id} : {rad.Name} : {rad.IsEnabled}");
            }

            Log(sb.ToString());
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLog.Text);
        }

        private void btnBTPanel_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:bluetooth");
        }
    }
}
