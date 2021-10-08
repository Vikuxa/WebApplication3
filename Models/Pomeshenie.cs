using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Pomeshenie
    {
        [Key]
        public int id { get; set; }
        public int kab_nom { get; set; }
        public int etazh { get; set; }
        public int zdanie_nom { get; set; }
        public string ulitsa { get; set; }
        public string gorod { get; set; }
    }
}
