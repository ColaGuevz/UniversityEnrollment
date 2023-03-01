using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    internal class Student
    {
        private string FirstName {  get; set; }
        private string MiddleName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        public string IDnumber { get;private set; }
        private string EmailAddress { get; set; }
        private string Address { get; set; }
        public string Program { get;private set; }

        public Student(string firstName, string middleName, string lastName, string email, string iDnumber, string emailAddress, string address, string program)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Email = email;
            this.IDnumber = iDnumber;
            this.EmailAddress = emailAddress;
            this.Address = address;
            this.Program = program;
        }
    }
}