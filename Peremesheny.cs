using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3
{
    public partial class Peremesheny
    {
        public int Id { get; set; }
        public int IdTechnika { get; set; }
        public int? Technikaid { get; set; }
        public int IdPomeshenie { get; set; }
        public int? Pomeshenieid { get; set; }
        public DateTime DataUstanivki { get; set; }
        public DateTime DataDemontazha { get; set; }
        public string Prichina { get; set; }

        public virtual Pomesheny Pomeshenie { get; set; }
        public virtual Technika Technika { get; set; }
    }
}
