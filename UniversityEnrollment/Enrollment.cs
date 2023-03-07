using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public class Enrollment
    {
        public Student StudIdNumber;
        public List <Instructor> InstIdNumber;
        public List <string> Subjects;
        public Enrollment(Student studIdnumber, List <Instructor> instIdnumber, List <string> subjects)
        {
            this.StudIdNumber = studIdnumber;
            this.InstIdNumber = instIdnumber;
            this.Subjects = subjects;
        }
    }
}
