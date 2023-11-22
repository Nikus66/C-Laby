using Lab1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Materials
{
    class ConcreteMaterial : AbstractMaterial
    {
        public ConcreteMaterial()
        {
            MaterialCost = 200;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }
    }
}
