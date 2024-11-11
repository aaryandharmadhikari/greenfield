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
namespace Membership
{
    public class AuthService : IAuthService
    {

         
        public bool ForgetPassword(string username)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            IDataRepository repository = new BinaryReposiTory();
            List<Credentials>credentials=repository.deserailizeuser("credentials.dat");
            foreach(Credentials cred in credentials)
            {
                if(cred.Email==username && cred.Password==password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool ResetPassword(string username, string oldpassword, string newpassword)
        {
            throw new NotImplementedException();
        }

        public void Seeding()
        {
           
        List<Credentials> credentials = new List<Credentials>();
        credentials.Add(new Credentials {Email="Salman@123",Password="123" });
        credentials.Add(new Credentials {Email="Samn@123",Password="234" });
        credentials.Add(new Credentials { Email = "Pom@343", Password = "345" });
        IDataRepository repo = new BinaryReposiTory();
         repo.serializeuser("credentials.dat", credentials);
        
           
        }
    }
}
