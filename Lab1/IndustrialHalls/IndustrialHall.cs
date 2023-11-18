using Lab1.Constructions;
using Lab1.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.IndustrialHalls
{
    internal class IndustrialHall: Construction
    {
        public IndustrialHall():base(12, 23, 34, 31, TypeOfMaterial.Brick)
        {
            
        }
    }
}
