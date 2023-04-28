using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Ingredients
    {
        // Declared variables 
        // Get and Set method
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredients(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        // ToString Method
        /* Returns a string representation of Ingredients 
           Microsoft, 2021 
           How to override the ToString method
           https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method */
        public override string ToString()
        {
            return $"{Quantity} {Unit} {Name}";
        }
    }
}
