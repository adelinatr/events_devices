using System;
using System.Collections.Generic;


namespace DeviceManagerEvents
{
    public class DeviceManager
    {
        List<Device> _devices;
        public event EventHandler ChangeStatus;

        public DeviceManager()
        {
            _devices = new List<Device>();
        }

        public void Add(Device device)
        {
            _devices.Add(device);
        }

        public void OnChangeStatus()
        {
            Console.WriteLine("Change status");

            ChangeStatus(this, null);
        }
    }
}