using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingPortal.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string contact { get; set; }

        public string Location { get; set; }

        /*public User(int iD, string firstName, string lastName, string email, string contact, string location)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            this.contact = contact;
            Location = location;
        }*/
    }
}