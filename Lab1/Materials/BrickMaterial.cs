using Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Materials
{
    class BrickMaterial : AbstractMaterial
    {
        public BrickMaterial()
        {
            MaterialCost = 100;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }
    }
}
