using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Kai0ymTanarTk
    {
        public int Ttkkod { get; set; }
        public int? Tkod { get; set; }
        public int? Ttkod { get; set; }

        public virtual Kai0ymTanar TkodNavigation { get; set; }
    }
}
