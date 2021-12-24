using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3
{
    public partial class RashodMaterial
    {
        public int Id { get; set; }
        public int IdMaterial { get; set; }
        public int? Materialid { get; set; }
        public DateTime DataUstanivki { get; set; }
        public DateTime DataDemontazha { get; set; }
        public string Prichina { get; set; }

        public virtual Material Material { get; set; }
    }
}
