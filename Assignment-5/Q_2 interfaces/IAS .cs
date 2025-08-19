using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5.Q_2_interfaces
{
    internal interface IAS /*IAuthenticationService*/
    {
        bool AuthenticateUser(string UserName, int Password);
        bool AuthorizeUser(string UserName, string Rol);
    }
}
