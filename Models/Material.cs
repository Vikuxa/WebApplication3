using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Material
    {
        [Key]
        public int id { get; set; } //атрибут для связи полей
        public string tip { get; set; }
        public string firma { get; set; }
        public string model { get; set; }

        //лист объектов из расхода материалов
        //связка со всеми записями из расхода
        //public List<User> Users { get; set; }

        public List<Rashod_material> Rashod_Materials { get; set; }
    }
}
