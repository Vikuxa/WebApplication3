using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3
{
    public partial class Technika
    {
        public Technika()
        {
            Peremeshenies = new HashSet<Peremesheny>();
        }

        public int Id { get; set; }
        public string Tip { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public int IdSotrudnik { get; set; }
        public int? Sotrudnikiid { get; set; }
        public int IdPomeshenie { get; set; }
        public int? Pomeshenieid { get; set; }

        public virtual Pomesheny Pomeshenie { get; set; }
        public virtual Sotrudniki Sotrudniki { get; set; }
        public virtual ICollection<Peremesheny> Peremeshenies { get; set; }
    }
}
