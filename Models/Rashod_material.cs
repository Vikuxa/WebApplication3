using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Rashod_material
    {
        [Key] 
        public int id { get; set; }
        public int id_technika { get; set; }
        [ForeignKey("id_technika")]//атрибут для связи как внешний ключ
        public Technika technika { get; set; }
        public int id_material { get; set; }
        [ForeignKey("id_material")]
        public Material material { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_ustanivki { get; set; }
        [DataType(DataType.Date)]
        public DateTime data_demontazha { get; set; }
        public string prichina { get; set; }
    }
}
