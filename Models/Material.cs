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
        public int id { get; set; }
        public string tip { get; set; }
        public string firma { get; set; }
        public string model { get; set; }
    }
}
