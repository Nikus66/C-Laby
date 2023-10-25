using System;
using lab1.construction;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
           var constr = new construction (32,32,3,6,"brik");
            Console.WriteLine(constr.BulidMaterial);
        }
    }
}
