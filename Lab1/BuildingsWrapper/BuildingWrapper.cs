using Lab1.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            return _construction.CalculateSquareCost();
        }

        public void DisplayCostDetails()
        {
            Console.WriteLine($"Square cost details for the building:");
            Console.WriteLine($"Height: {_construction.Height}, Width: {_construction.Width}, Entrances:{_construction.Entrances}, Human Capacity: {_construction.HumanCapacity}, Build Material:{_construction.BuildMaterial}");
            Console.WriteLine($"Square Cost: {_construction.CalculateSquareCost()}");
        }
        public void DisplayConstructionInfoFromWrapper()
        {
            _construction.DisplayConstructionInfo();
        }

    }
}
