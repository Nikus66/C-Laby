using Lab1.Constructions.Models;
using Lab1.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Abstract
{
    abstract class AbstractCommercialBuilding : Construction
    {
        public string BusinessType { get; set; }
        protected AbstractCommercialBuilding(float height, float width, int
        entrances, int humanCapacity, TypeOfMaterial buildMaterial, string
        businessType)
        : base(height, width, entrances, humanCapacity, buildMaterial)
        {
            BusinessType = businessType;
        }
        public abstract void OpenBusiness();
    }
}
