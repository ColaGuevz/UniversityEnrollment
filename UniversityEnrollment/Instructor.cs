using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public class Instructor: User
    {
        public string Department { get; private set; }
        public Instructor (string firstName, string middleName, string lastName, DateTime birthdate, string address, string emailAddress, string userName, string password, string iDnumber, string degreePogram, string department):base(firstName, middleName, lastName, birthdate, address, emailAddress, userName, password, iDnumber)
        {
            this.Department = department;
        }
    }
}