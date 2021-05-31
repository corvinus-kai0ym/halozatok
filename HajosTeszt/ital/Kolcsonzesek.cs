using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.ital
{
    public partial class Kolcsonzesek
    {
        public int Id { get; set; }
        public int? Ki { get; set; }
        public int? Mit { get; set; }
        public DateTime? KiDatum { get; set; }
        public DateTime? VisszaDatum { get; set; }
    }
}
