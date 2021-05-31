using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Instructor
    {
        public Instructor()
        {
            Lessons = new HashSet<Lesson>();
        }

        public int InstructorSk { get; set; }
        public string Salutation { get; set; }
        public string Name { get; set; }
        public int StatusFk { get; set; }
        public string EmploymentFk { get; set; }

        public virtual Status StatusFkNavigation { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
