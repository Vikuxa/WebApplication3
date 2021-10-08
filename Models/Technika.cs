using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Sotrudniki sotrudniki { get; set; }
        public int id_pomeshenie { get; set; }
        public Pomeshenie pomeshenie { get; set; }
    }
}
