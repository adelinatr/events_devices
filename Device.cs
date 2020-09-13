using System;

namespace DeviceManagerEvents
{
    public class Device
    {
        private bool _status=false;
        public string Name { set; get; }

        public void Enable()
        {
            _status = true;
            InformManager(this, null);
        }

        public void Disable()
        {
            _status = false;
            InformManager(this, null);
        }

        public void InformManager(object sender, EventArgs args)
        {
            string statusStr = _status? "enabled": "disabled";
            Console.WriteLine("New status " + statusStr + " for device " + Name);
        }
    }
}