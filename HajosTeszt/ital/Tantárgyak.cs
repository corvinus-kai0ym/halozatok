using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Tantárgyak
    {
        public int Tkód { get; set; }
        public string Tantárgynév { get; set; }
        public int? Tantárgyfelelős { get; set; }
        public string Tantargykod { get; set; }
        public int? Kredit { get; set; }
    }
}
