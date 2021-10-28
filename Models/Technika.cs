using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Technika
    {
        [Key]
        public int id { get; set; }
        public string tip { get; set; }
        public string firma { get; set; }
        public string model { get; set; }
        public int id_sotrudnik { get; set; }
        [ForeignKey("id_sotrudnik")]
        public Sotrudniki sotrudniki { get; set; }
        public int id_pomeshenie { get; set; }
        [ForeignKey("id_pomeshenie")]
        public Pomeshenie pomeshenie { get; set; }
        
        public List<Peremeshenie> Peremeshenies { get; set; }
        public List<Rashod_material> Rashod_Materials { get; set; }
    }
}
