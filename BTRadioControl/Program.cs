using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Radios;

namespace BTRadioControl
{
    internal class Program
    {
        /*
         https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.devices.radios/radio_fromidasync_1322863552.md

         A static method that retrieves a Radio object. The method accepts the 'Device.Id' found through Windows.Devices.Enumeration.DeviceInformation.FindAllAsync. 
         This procedure is more reliable than using GetRadiosAsync to obtain a radio in situations where a USB Radio has failed or been removed on a Windows 10 workstation. 
         In this instance of a failed or removed radio, GetRadiosAsync returns no bluetooth radio. FindAllAsync, in contrast, returns a valid Id that can be passed to FromIdAsync 
         to obtain the radio object, which will report itself as now being in the state of 'Disabled'.
        */

        static void Main(string[] args)
        {
            // usage BTRadioControl.exe d, 1, 0

            MainAsync(args[0]).Wait();
        }

        static async Task MainAsync(String op)
        {
            if ("d" == op)
            {
                var radiosf = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync();

                Console.WriteLine("Listing..");
                for (int i = 0; i < radiosf.Count; i++)
                {
                    var rad = radiosf[i];
                    Console.WriteLine($"{rad.Id} : {rad.Name} : {rad.IsEnabled}");
                }
            }
            else
            {
                var accessLevel = await Radio.RequestAccessAsync();

                if (accessLevel == RadioAccessStatus.Allowed)
                {
                    var radbt = await Radio.FromIdAsync(ConfigurationManager.AppSettings["BTDeviceId"]);

                    if ("0" == op)
                        await radbt.SetStateAsync(RadioState.Off);
                    else
                        await radbt.SetStateAsync(RadioState.On);
                }
            }

            Console.WriteLine("Everything is OK");
        }
    }
}