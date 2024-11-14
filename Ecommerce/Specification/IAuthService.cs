using Pokolib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Specification
{
    public  interface IAuthService
    {
        bool Login(string username, string password);
        bool Register(User user, string password);
        string ForgotPassword(string username);
        bool ResetPassword(string username, string newPassword);



    }
}
