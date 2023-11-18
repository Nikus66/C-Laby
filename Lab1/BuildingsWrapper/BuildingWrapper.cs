using Lab1.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BuildingsWrapper
{
    internal class BuildingWrapper
    {
        private Construction _construction { get; set; }

        public BuildingWrapper(Construction construction)
        {
            _construction = construction;
        }

        public double GetWrapperSquareCost()
        {
            return _construction.GetSquareCost();
        }

    }
}
