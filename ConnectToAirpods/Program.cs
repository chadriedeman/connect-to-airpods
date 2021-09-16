using InTheHand.Net.Sockets;
using System;
using System.Linq;

namespace ConnectToAirpods
{
    public class Program
    {
        public static void Main()
        {
            using var bluetoothClient = new BluetoothClient();

            var devices = bluetoothClient.DiscoverDevices();

            var airPodsPro = devices.FirstOrDefault(device => device.DeviceName == "AirPods Pro");

            if (airPodsPro == null || airPodsPro.Connected)
            {
                Environment.Exit(-1);
            }

            //bluetoothClient.Connect(airPodsPro.DeviceAddress, )
        }
    }
}
