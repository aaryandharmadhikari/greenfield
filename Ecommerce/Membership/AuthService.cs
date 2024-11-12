using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BinaryRepositoryApp;
using Membership;
using Specification;
using Pokolib;
using System.Net;
namespace Membership
{
    public class AuthService : IAuthService
    {
        public string ForgotPassword(string username)
        {
            IDataRepository<Credential> dataRepository = BinaryRepository<Credential>.Create();
            List<Credential> credentialList = dataRepository.Deserialize<Credential>("credentials.dat");
            foreach (var user in credentialList)
            {
                if (user.Email == username)
                {
                    return user.Password;
                }
            }
            return null;
        }

        public bool Login(string username, string password)
        {
            IDataRepository<Credential> repository = BinaryRepository<Credential>.Create();
            List<Credential> credentials = repository.Deserialize<Credential>("credentials.dat");
            foreach (Credential user in credentials)
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

        public bool Register(User user, string password)
        {
            IDataRepository<User> userRepo = BinaryRepository<User>.Create();
            IDataRepository<Credential> credRepo = BinaryRepository<Credential>.Create();

            List<User> exisingUser = userRepo.Deserialize<User>("users.dat");
            exisingUser.Add(user);
            userRepo.Serialize("users.dat", exisingUser);

            List<Credential> existingCredentials = credRepo.Deserialize<Credential>("credentials.dat");
            existingCredentials.Add(new Credential { Email = user.Email, Password = password });
            credRepo.Serialize("credentials.dat", existingCredentials);

            return true;
        }

        public bool ResetPassword(string username, string newPassword)
        {
            IDataRepository<Credential> credRepo = BinaryRepository<Credential>.Create();

            List<Credential> credentials = credRepo.Deserialize<Credential>("credentials.dat");

            foreach (var user in credentials)
            {
                if (user.Email == username)
                {
                    user.Password = newPassword;
                    credRepo.Serialize("credentials.dat", credentials);
                    return true;
                }

            }
            return false;
        }
        public void SeedingCred()
        {
            List<Credential> credentials = new List<Credential>();
            credentials.Add(new Credential { Email = "aryan.com", Password = "1234" });
            credentials.Add(new Credential { Email = "shahrukh.com", Password = "1234" });
            credentials.Add(new Credential { Email = "salman.com", Password = "1234" });
            credentials.Add(new Credential { Email = "amitabh.com", Password = "1234" });
            credentials.Add(new Credential { Email = "abhishek.com", Password = "1234" });
            IDataRepository<Credential> repository = BinaryRepository<Credential>.Create();
            repository.Serialize("credentials.dat", credentials);
        }
        public void SeedingUser()
        {
            List<User> users = new List<User>();
            users.Add(new User { ID = 1, FirstName = "Vivek", LastName = "Oberoi", Email = "Vivek.com", contact = "123456"});
            users.Add(new User { ID = 2, FirstName = "Shubham", LastName = "Bhosale", Email = "Shubham.com", contact = "234567" });
            users.Add(new User { ID = 3, FirstName = "Raj", LastName = "Thakre", Email = "Raj.com", contact =" 345678" });
            users.Add(new User { ID = 4, FirstName = "Ankush", LastName = "Chowdhary", Email = "Ankush.com", contact = "456789" });
            users.Add(new User { ID = 5, FirstName = "Swapnil", LastName = "Joshi", Email = "swwapnil.com", contact = "6789012" });
            IDataRepository<User> repository = BinaryRepository<User>.Create();
            repository.Serialize("users.dat", users);
        }

        public void GetAllUsers()
        {
            IDataRepository<User> userRepo = BinaryRepository<User>.Create();
            List<User> users = userRepo.Deserialize<User>("users.dat");
            foreach (User user in users)
            {
                Console.WriteLine(user.ID + " " + user.FirstName + " " + user.LastName + " " + user.Email + " ");
            }
        }
        public Credential GetCredByEmail(string email)
        {
            IDataRepository<Credential> userRepo = BinaryRepository<Credential>.Create();
            List<Credential> credentials = userRepo.Deserialize<Credential>("credentials.dat");
            foreach (Credential cred in credentials)
            {
                if (cred.Email == email) return cred;
            }
            return null;
        }


    }
}