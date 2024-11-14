using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;
using System.IO;
using BankingPortal.Models;
using BankingPortal.Repositories;
namespace BankingPortal.Services
{
    public class AuthService : IAuthServices
    {
        public AuthService() 
        {
            SeedingUser();
            SeedingCred();
        }
        public bool ForgotPassword(string username)
        {
            IDataRepository<Credentials> dataRepository = new JsonDataRepository<Credentials>();
            List<Credentials> CredentialsList = dataRepository.Deserialize("Credentialss.json");
            foreach (var user in CredentialsList)
            {
                if (user.Email == username)
                {
                    return true;
                }
            }
            return false;

        }

        public bool Login(string username, string password)
        {


            IDataRepository<Credentials> repository =new JsonDataRepository<Credentials>();
            List<Credentials> Credentialss= repository.Deserialize(@"D:/Credentialss.json");


            foreach (Credentials user in Credentialss)
            {
                if (user.Email == username)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                    else
                    {
                        //wrong password
                        return false;
                    }
                }
                else
                {
                    //user not exist
                    return false;
                }
            }
            return false;


        }

        public bool Register(User user,string password)
        {
            IDataRepository<User> userRepo = new JsonDataRepository<User>();
            IDataRepository<Credentials> credRepo =new JsonDataRepository<Credentials>();

            List<User> exisingUser = userRepo.Deserialize(@"D:/users.json");
            exisingUser.Add(user);
            

            List<Credentials> existingCredentialss = credRepo.Deserialize(@"D:/Credentialss.json");
           existingCredentialss.Add(new Credentials { Email=user.Email, Password=password });
            

            return userRepo.Serialize(@"D:/users.json", exisingUser) && credRepo.Serialize(@"D:/Credentialss.json", existingCredentialss);
        }

        public bool ResetPassword(string username, string OldPassword, string NewPassword)
        {
            IDataRepository<Credentials> credRepo = new JsonDataRepository<Credentials>();

            List<Credentials> Credentialss = credRepo.Deserialize(@"D:/Credentialss.json");

            foreach (Credentials credential in Credentialss)
            {
                if (credential.Email == username && credential.Password==OldPassword)
                {
                    credential.Password = NewPassword;
                    credRepo.Serialize(@"D:/Credentialss.json", Credentialss);
                    return true;
                }

            }
            return false;
        }

        public static void SeedingCred()
        {
            List<Credentials> Credentials = new List<Credentials>();
            Credentials.Add(new Credentials { Email = "aryan.com", Password = "1234" });
            Credentials.Add(new Credentials { Email = "shahrukh.com", Password = "1234" });
            Credentials.Add(new Credentials { Email = "salman.com", Password = "1234" });
            Credentials.Add(new Credentials { Email = "amitabh.com", Password = "1234" });
            Credentials.Add(new Credentials { Email = "abhishek.com", Password = "1234" });
            IDataRepository<Credentials> repository =new JsonDataRepository<Credentials>();
            repository.Serialize(@"D:/Credentialss.json", Credentials);
        }
        public static void SeedingUser()
        {
            List<User> users = new List<User>();
            users.Add(new User { ID = 1, FirstName = "Vivek", LastName = "Oberoi", Email = "Vivek.com", contact = "123456" });
            users.Add(new User { ID = 2, FirstName = "Shubham", LastName = "Bhosale", Email = "Shubham.com", contact = "234567" });
            users.Add(new User { ID = 3, FirstName = "Raj", LastName = "Thakre", Email = "Raj.com", contact = " 345678" });
            users.Add(new User { ID = 4, FirstName = "Ankush", LastName = "Chowdhary", Email = "Ankush.com", contact = "456789" });
            users.Add(new User { ID = 5, FirstName = "Swapnil", LastName = "Joshi", Email = "swwapnil.com", contact = "6789012" });
            IDataRepository<User> repository = new JsonDataRepository<User>();
            repository.Serialize(@"D:/users.json", users);
        }




    }
}