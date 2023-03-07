using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public class Student: User
    {
        public Course CourseName { get; private set; }
        public int YearLevel { get; set; }

        public Student(string firstName, string middleName, string lastName, DateTime birthdate, string address, string emailAddress, string userName, string password, string iDnumber, Course courseName, int yearLevel) : base(firstName, middleName, lastName, birthdate, address, emailAddress, userName, password, iDnumber)
        {
            this.CourseName = courseName;
            this.YearLevel = yearLevel;
        }
    }
}