using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Teszttetel
    {
        public int Kod { get; set; }
        public int? Fejkod { get; set; }

        public virtual Tesztfej FejkodNavigation { get; set; }
    }
}
