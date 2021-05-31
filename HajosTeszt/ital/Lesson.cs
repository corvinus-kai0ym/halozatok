using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Lesson
    {
        public int LessonSk { get; set; }
        public string Name { get; set; }
        public int InstructorFk { get; set; }
        public int DayFk { get; set; }
        public int TimeFk { get; set; }
        public int RoomFk { get; set; }

        public virtual Day DayFkNavigation { get; set; }
        public virtual Instructor InstructorFkNavigation { get; set; }
        public virtual Room RoomFkNavigation { get; set; }
        public virtual Time TimeFkNavigation { get; set; }
    }
}
