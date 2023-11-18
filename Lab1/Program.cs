using System;
using Lab1.BuildingsWrapper;
using Lab1.Constructions;
using Lab1.Constructions.Models;
using Lab1.IndustrialBuildings;
using Lab1.IndustrialHalls;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var constr = new Construction(32, 23, 3, 6, TypeOfMaterial.Brick);
            Console.WriteLine(constr.BuildMaterial);

            var constr2 = new Construction();
            Console.WriteLine(constr2.Width);

            var constructionDto = new CreateConstructionDto {
                Height = 21,
                Width = 37,
                Entrances = 3,
                HumanCapacity = 6,
                BuildMaterial = TypeOfMaterial.Wood
            };

            var constr3 = new Construction(constructionDto);
            Console.WriteLine(constr3.BuildMaterial);

            Console.WriteLine(constr3.GetSquareCost());

            var building = new ResidentalBuilding(2);
            var hall = new IndustrialHall();

            Console.WriteLine(building.BuildMaterial);
            Console.WriteLine(building.Width);

            Console.WriteLine(hall.BuildMaterial);
            Console.WriteLine(hall.Width);
            Console.WriteLine(hall.Height);

            var wrapper1 = new BuildingWrapper(building);
            var wrapper2 = new BuildingWrapper(hall);

            Console.WriteLine(wrapper1.GetWrapperSquareCost());
            Console.WriteLine(wrapper2.GetWrapperSquareCost());
        }
    }
}