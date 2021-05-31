using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Tesztfej
    {
        public Tesztfej()
        {
            Teszttetels = new HashSet<Teszttetel>();
        }

        public int Kod { get; set; }
        public string Szoveg { get; set; }

        public virtual ICollection<Teszttetel> Teszttetels { get; set; }
    }
}
