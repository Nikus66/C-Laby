using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.construction
{
    class construction
    {
        public construction(float height, float width, int entrances, int humancapacity, string buildmaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humancapacity;
            _buildMaterial = buildmaterial;
            
        }
        private string _buildMaterial { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances  { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial 
        { 
            get 
            {
                return _buildMaterial;
            }
            set {
                _buildMaterial = value;
            }
        }

    }
}
