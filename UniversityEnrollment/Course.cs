using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public class Course
    {
        private string CourseId { get; set; }
        private string CourseDescription { get; set; }

        public Course(string courseId, string courseDescription)
        {
            this.CourseId = courseId;
            this.CourseDescription = courseDescription;
        }
    }
}
