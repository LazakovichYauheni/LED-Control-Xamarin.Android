using Android.Bluetooth;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEDControl.core
{
    public class BluetoothDeviceReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;

            if (action == BluetoothDevice.ActionFound)
            {
                // Get device
                BluetoothDevice newDevice = (BluetoothDevice)intent.GetParcelableExtra(BluetoothDevice.ExtraDevice);

                // now you could do your job with newDevice
                // etc. check if newDevice is not already in a list and then use it in a ListView
            }
        }
    }
}
