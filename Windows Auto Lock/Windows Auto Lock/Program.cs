using System;
using System.Linq;
using System.Threading;
using InTheHand.Net.Sockets;
using System.Windows.Forms;
using System.IO;

namespace Windows_Auto_Lock
{
    internal class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern void LockWorkStation();

        static int disconnectCount = 0;

        static string bluetoothName = "";
        static string deviceID = "";

        static void Main(string[] args)
        {
            //Loading config file
            var cfgData = File.ReadAllText("AutoLock.cfg").Split(',');
            bluetoothName = cfgData[0];
            deviceID = cfgData[1];

            try
            {
                BluetoothClient client = new BluetoothClient();
                
                client.InquiryLength = TimeSpan.FromSeconds(3);

                while (true)
                {
                    BluetoothDeviceInfo[] devices = client.DiscoverDevicesInRange();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                    if (devices.Length == 0 || !devices.Any(x => x.DeviceName == bluetoothName && x.Authenticated == true && x.DeviceAddress.ToString() == deviceID))
                    {
                        disconnectCount++;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   

                        if (disconnectCount > 1)
                        {
                            disconnectCount = 0;
                            LockWorkStation();
                        }

                    }
                    else
                    {
                        disconnectCount = 0;
                    }

                    Thread.Sleep(100);

                    //10F605245646
                    //Devil
                    //True
                }
            }
            catch(Exception)
            {

            }
            
        }

    }
}
