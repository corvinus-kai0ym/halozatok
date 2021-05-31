using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Tagok
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Cim { get; set; }
        public string Kedvencstilus { get; set; }
        public int? Kedvencnyelv { get; set; }
    }
}
