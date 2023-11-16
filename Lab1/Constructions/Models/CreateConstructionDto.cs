using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Constructions.Models
{
    internal class CreateConstructionDto
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public TypeOfMaterial BuildMaterial { get; set; }
    }
}
