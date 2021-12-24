using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3
{
    public partial class Sotrudniki
    {
        public Sotrudniki()
        {
            Technikas = new HashSet<Technika>();
        }

        public int Id { get; set; }
        public string F { get; set; }
        public string I { get; set; }
        public string O { get; set; }
        public string Dolzhnost { get; set; }
        public string Tel { get; set; }

        public virtual ICollection<Technika> Technikas { get; set; }
    }
}
