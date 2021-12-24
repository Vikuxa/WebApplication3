using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3
{
    public partial class Material
    {
        public Material()
        {
            RashodMaterials = new HashSet<RashodMaterial>();
        }

        public int Id { get; set; }
        public string Tip { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }

        public virtual ICollection<RashodMaterial> RashodMaterials { get; set; }
    }
}
