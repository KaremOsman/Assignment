using Assignment_5.Q_2_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5.Q_2_Classes
{
    internal class BasicAS : IAS /*BasicAuthenticationService Class*/
    {
        UserApp[] Users = new UserApp[]  /*Simple Data Base For Validation */
        {
            new UserApp { UserName = "karem", Password = 1234, Role = "Gust" },
            new UserApp { UserName = "Osman", Password = 5678, Role = "Devol" },
            new UserApp { UserName = "Mohamed", Password = 9012, Role = "Deis" }
        };
        public bool AuthenticateUser(string UserName, int Password) /*Validation For User Authenticated*/
        {
            foreach (var user in Users)
            {
                if ( user.UserName == UserName  && user.Password == Password )
                {
                    Console.WriteLine("User Is Authenticated");
                    return true;
                }
            }
            Console.WriteLine("User Is Not Authenticated ");
            return false;

        }

        public bool AuthorizeUser(string UserName, string Rol)  /*Validation for User Authorized*/
        {
            foreach (var user in Users)
            {
                if (user.UserName == UserName && user.Role == Rol)
                {
                    Console.WriteLine("User Is authorized");
                    return true;
                }
            }
            Console.WriteLine("User Is Not authorized");
            return false;
        }
    }
}
