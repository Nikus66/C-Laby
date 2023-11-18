using Lab1.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.IndustrialBuildings
{
    internal class ResidentalBuilding:Construction
    {
        public int NumberOfFloors { get; set; }

        public ResidentalBuilding(int numberOfFloors){
            NumberOfFloors = numberOfFloors;
        }
    }
}
