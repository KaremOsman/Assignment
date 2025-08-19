using Assignment_5.Q_3_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5.Q_3_Classes
{
    internal class SmsNS : INotificationS /*SMS Notification Service Class*/
    {
        public void SendNotification(string Recipien, string Massage)
        {
            Console.WriteLine( "SMS sent To : " + Recipien + " ,\" " + Massage + "\".");
        }
    }
}
