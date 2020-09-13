using System;

namespace DeviceManagerEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            DeviceManager manager = new DeviceManager();
            Device d1 = new Device { Name = "USB" };
            manager.Add(d1);
            manager.ChangeStatus += new EventHandler(d1.InformManager);

            Device d2 = new Device { Name = "Card" };
            manager.Add(d2);
            manager.ChangeStatus += new EventHandler(d2.InformManager);
            
            //raises events
            d1.Enable();
            d2.Disable();

            //raises event
            manager.OnChangeStatus();
         }
    }
}
