using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Step
    {
        // Declared variables 
        // Get and Set method
        public string Description { get; set; }

        public Step(string description)
        {
            Description = description;
        }

        // ToString Method
        /* Returns a string representation of Steps 
           Microsoft, 2021 
           How to override the ToString method
           https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method */
        public override string ToString()
        {
            return Description;
        }
    }
}
