using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1.Constructions.Models;

namespace Lab1.Constructions
{
    internal class Construction
    {
        public Construction(float height, float width, int entrances, int humanCapacity, TypeOfMaterial buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public Construction(CreateConstructionDto constructionDto)
        {
            Height = constructionDto.Height;
            Width = constructionDto.Width;
            Entrances = constructionDto.Entrances;
            HumanCapacity = constructionDto.HumanCapacity;
            BuildMaterial = constructionDto.BuildMaterial;
        }

        public Construction()
        {
            Height = 100;
            Width = 100;
            Entrances = 3;
            HumanCapacity = 20;
            BuildMaterial = TypeOfMaterial.Concrete;
        }

        private TypeOfMaterial _buildMaterial { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public TypeOfMaterial BuildMaterial
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                _buildMaterial = value;
            }
        }

        public double GetSquareCost()
        {
            if (BuildMaterial == TypeOfMaterial.Brick)
            {
                return Width * Height * 0.9 * 0.8;
            }
            else if (BuildMaterial == TypeOfMaterial.Concrete)
            {
                return Width * Height * 0.9 * 0.87;
            }
            else if (BuildMaterial == TypeOfMaterial.Wood)
            {
                return Width * Height * 0.9 * 0.78;
            }
            return 0;
        }
    }
}
