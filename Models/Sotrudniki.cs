using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Sotrudniki
    {
        [Key]
        public int id { get; set; }
        public string f { get; set; }
        public string i { get; set; }
        public string o { get; set; }
        public string dolzhnost { get; set; }
        public string tel { get; set; }
    }
}
