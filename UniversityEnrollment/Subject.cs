using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnrollment
{
    public class Subject
    {
        public string SubjectName { get; private set; }
        public string SubjectId { get; private set; }
        public string SubjectType { get; private set; }

        
        public Subject(string subjectName, string subjectId, string subjectType)
        {
            this.SubjectName = subjectName;
            this.SubjectId = subjectId;
            this.SubjectType = subjectType;
        }
    }
}
