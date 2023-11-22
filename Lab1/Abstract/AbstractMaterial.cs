using Lab1.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstract
{
    abstract class AbstractMaterial : Construction
    {
        protected double MaterialCost;
        public abstract double CalculateMaterialCost();
    }
}
