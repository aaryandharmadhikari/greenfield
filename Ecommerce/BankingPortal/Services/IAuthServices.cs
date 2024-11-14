using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingPortal.Models;

namespace BankingPortal.Services
{
    public  interface IAuthServices
    {
        bool Login(string username, string password);
        bool Register(User user,string password);
       
        bool ForgotPassword(string username);
        bool ResetPassword(string username, string oldPassword, string newPassword);
    }
}
