using Assignment_5.Q_3_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5.Q_3_Classes
{
    internal class PushNS : INotificationS       /*Push Notification Service Class*/
    {
        public void SendNotification(string Recipien, string Massage)
        {
            Console.WriteLine($"Notifiction Pushed To : {Recipien}, \"{Massage}\". ");
        }
    }
}
