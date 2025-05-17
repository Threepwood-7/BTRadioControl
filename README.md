# Bluetooth Windows Radio Control
There once was a ps1 script that used to work. Then it didn't. I needed a way to set Bluetooth Radio ON and OFF from the command line.

The Key is to reference the correct assemblies and use the `Windows.Devices.Enumeration.DeviceInformation.FindAllAsync()` instead of `GetRadiosAsync`
* Windows Kits\10\UnionMetadata\10.0.20348.0\Windows.winmd
* Microsoft SDKs\NuGetPackages\System.Runtime.WindowsRuntime\4.0.10\lib\netcore50\System.Runtime.WindowsRuntime.dll

## Usage
Command Line version
`BTRadioControl.exe d, 1, 0`

* d to list devices
* 1 on
* 0 off

Edit edit App.config and set the ID to the one that looks like SWD#RADIO ... 

## References
Links
* [PowerShell ps1 script to manage bluetooth status stopped working](https://github.com/PowerShell/PowerShell/issues/16731)
* [Windows.Devices.Radios may be not work correctly in x86](https://github.com/Microsoft/cppwinrt/issues/47)
* [Windows Bluetooth ON/OFF API](https://stackoverflow.com/questions/48603684/windows-bluetooth-on-off-api/48628192)
* [Calling Windows 10 APIs From a Desktop Application](https://blogs.windows.com/windowsdeveloper/2017/01/25/calling-windows-10-apis-desktop-application/#8ZHWGWDkBfR7JgpZ.97)
* [RadioModel](https://github.com/microsoft/Windows-universal-samples/blob/main/Samples/RadioManager/cppwinrt/RadioModel.cpp)
* [RadioModel.cs](https://github.com/microsoft/Windows-universal-samples/blob/main/Samples/RadioManager/cppwinrt/RadioModel.cpp)
