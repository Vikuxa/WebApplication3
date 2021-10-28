using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Peremeshenie
    {
        [Key]
        public int id { get; set; }
        public int id_technika { get; set; }
        [ForeignKey("id_technika")]
        public Technika technika { get; set; }
        public int id_pomeshenie { get; set; }
        [ForeignKey("id_pomeshenie")]
        public Pomeshenie pomeshenie { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_ustanivki { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_demontazha { get; set; }

        public string prichina { get; set; }
        public int id_sotrudnik { get; set; }
        [ForeignKey("id_sotrudnik")]
        public Sotrudniki sotrudniki { get; set; }
    }
}
