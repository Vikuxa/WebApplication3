using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3
{
    public partial class Pomesheny
    {
        public Pomesheny()
        {
            Peremeshenies = new HashSet<Peremesheny>();
            Technikas = new HashSet<Technika>();
        }

        public int Id { get; set; }
        public int KabNom { get; set; }
        public int Etazh { get; set; }
        public int ZdanieNom { get; set; }
        public string Ulitsa { get; set; }
        public string Gorod { get; set; }

        public virtual ICollection<Peremesheny> Peremeshenies { get; set; }
        public virtual ICollection<Technika> Technikas { get; set; }
    }
}
