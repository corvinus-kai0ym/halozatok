using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Kai0ymTanar
    {
        public Kai0ymTanar()
        {
            Kai0ymTanarTks = new HashSet<Kai0ymTanarTk>();
        }

        public int OktatoId { get; set; }
        public string Nev { get; set; }
        public string Titulus { get; set; }
        public int? Beosztás { get; set; }
        public int? Status { get; set; }
        public string Vegzettseg { get; set; }

        public virtual ICollection<Kai0ymTanarTk> Kai0ymTanarTks { get; set; }
    }
}
