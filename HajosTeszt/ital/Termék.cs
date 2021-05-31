using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Termék
    {
        public string Termekkod { get; set; }
        public string Megnevezes { get; set; }
        public int? KatId { get; set; }
        public double? Listaar { get; set; }
        public string Leiras { get; set; }
        public int? RaktarKod { get; set; }
        public double? Keszlet { get; set; }
        public string Megys { get; set; }
        public string Felvitte { get; set; }
        public DateTime? Felvitel { get; set; }
    }
}
