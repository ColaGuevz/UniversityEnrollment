using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public abstract class User
    {
        private string FirstName { get; set; }
        private string MiddleName { get; set; }
        private string LastName { get; set; }
        private DateTime Birthdate { get; set; }
        private string Address { get; set; }
        private string EmailAddress { get; set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string IDnumber { get; private set; }

        public User(string firstName, string middleName, string lastName, DateTime birthdate, string address, string emailAddress, string userName, string password, string iDnumber)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Birthdate = birthdate;
            Address = address;
            EmailAddress = emailAddress;
            UserName = userName;
            Password = password;
            IDnumber = iDnumber;
        }
    }
}
