using System;
using Lab1.Constructions;
using Lab1.Constructions.Models;

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

        }
    }
}