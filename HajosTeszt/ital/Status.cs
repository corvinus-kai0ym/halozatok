using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Status
    {
        public Status()
        {
            Instructors = new HashSet<Instructor>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}
