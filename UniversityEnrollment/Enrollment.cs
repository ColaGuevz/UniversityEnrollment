﻿using System;
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
        public Instructor InstIdNumber;
        public ArrayList Subjects;
        public Enrollment(Student studIdnumber, Instructor instIdnumber)
        {
            this.StudIdNumber = studIdnumber;
            this.InstIdNumber = instIdnumber;
        }
    }
}