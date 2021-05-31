using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Dvd
    {
        public int Id { get; set; }
        public string Cim { get; set; }
        public string Stilus { get; set; }
        public string Szam { get; set; }
        public double? Nettoar { get; set; }
        public double? Lang { get; set; }
        public int? RaktárKészlet { get; set; }
    }
}
