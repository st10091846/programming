using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Recipe
    {
        // Scaling factor variable
        private Ingredients[] Ingredients;
        private Step[] Steps;
        private double ScalingFactor;

        public Recipe(int numIngredients, int numSteps)
        {
            Ingredients = new Ingredients[numIngredients];
            Steps = new Step[numSteps];
            ScalingFactor = 1;
        }

        // Set ingredient method
        public void SetIngredient(int index, string name, double quantity, string unit)
        {
            Ingredients[index] = new Ingredients(name, quantity, unit);  // This creates a new ingredient (w3schools, 2022)
        }

        // Set step method
        public void SetStep(int index, string description)
        {
            Steps[index] = new Step(description); // This creates a new step  (w3schools, 2022)
        }

        // Print recipe method
        // Fulfils the requirements of displaying the full recipe in a neat format to the user
        public void PrintRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (Ingredients ingredient in Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine();
            Console.WriteLine("Steps:");
            /* Using Indexers
               Microsoft, 2021 
               https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers */
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        // Scale recipe method
        // Fulfils the requirements of scaling the full recipe by a factor of 0.5 (half), 2 (double) or 3 (triple)
        public void ScaleRecipe(double factor)
        {
            ScalingFactor = factor;
            foreach (Ingredients ingredient in Ingredients)
            {
                ingredient.Quantity *= factor; // Calculation multiplying the quantity by the factor
            }
        }

        // Reset method
        // Resets the scaled recipe back to its original values 
        /* Some of the following code was taken from stackoverflow
           How do I reinitialize or reset the properties of a class?
           https://stackoverflow.com/questions/708352/how-do-i-reinitialize-or-reset-the-properties-of-a-class */
        public void ResetQuantities()
        {
            foreach (Ingredients ingredient in Ingredients)
            {
                ingredient.Quantity /= ScalingFactor; // Calculation dividing the quantity by the scaling factor
            }
            ScalingFactor = 1;
        }

        // Clear Recipe method 
        // Clears all data from the previous actions, allowing the user to enter a new recipe
        public void ClearRecipe()
        {
            Ingredients = new Ingredients[Ingredients.Length];
            Steps = new Step[Steps.Length];
            ScalingFactor = 1;
        }
    }
}

