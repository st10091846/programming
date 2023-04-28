using System;

namespace RecipeApp
{
    class Program
    {
        static void Main()
        {
            // User input for number of ingredients
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            // User input for number of steps
            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe(numIngredients, numSteps); // This creates a new recipe (w3schools, 2022)

            /* Using Indexers
              Microsoft, 2021 
              https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers */
            for (int i = 0; i < numIngredients; i++)
            {
                // User input for name, quantity and units
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the quantity of {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter the unit of measurement for {name}: ");
                string unit = Console.ReadLine();

                recipe.SetIngredient(i, name, quantity, unit);
            }

            for (int i = 0; i < numSteps; i++)
            {
                // User input for steps
                Console.Write($"Enter step {i + 1}: ");
                string description = Console.ReadLine();

                recipe.SetStep(i, description);
            }

            Console.WriteLine("Full Recipe:");
            recipe.PrintRecipe();

            // While Loop and Switch Case
            /* Some of the following code was taken from Krishna Singh
               https://www.c-sharpcorner.com/code/1217/simple-c-program-of-while-loop-and-switch-case.aspx */
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Scale recipe");
                Console.WriteLine("2. Reset recipe");
                Console.WriteLine("3. Clear recipe");
                Console.WriteLine("4. Close App");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    // User scaled recipe by entering one of the scaling factors
                    case 1:
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                        Console.WriteLine($"Recipe scaled by {factor}:");
                        recipe.PrintRecipe();
                        break;
                    // User reset the recipe, quantities are reset back to its original values
                    case 2:
                        recipe.ResetQuantities();
                        Console.WriteLine("Successully Reset Recipe!");
                        recipe.PrintRecipe();
                        break;
                    // User cleared the existing recipe
                    case 3:
                        recipe.ClearRecipe();
                        Console.WriteLine("Successful Recipe Cleared!");
                        Console.Write("Enter the new number of ingredients: ");
                        numIngredients = int.Parse(Console.ReadLine());

                        Console.Write("Enter the new number of steps: ");
                        numSteps = int.Parse(Console.ReadLine());

                        recipe = new Recipe(numIngredients, numSteps);

                        for (int i = 0; i < numIngredients; i++)
                        {
                            Console.Write($"Enter the name of ingredient {i + 1}: ");
                            string name = Console.ReadLine();

                            Console.Write($"Enter the quantity of {name}: ");
                            double quantity = double.Parse(Console.ReadLine());

                            Console.Write($"Enter the unit of measurement for {name}: ");
                            string unit = Console.ReadLine();

                            recipe.SetIngredient(i, name, quantity, unit);
                        }

                        for (int i = 0; i < numSteps; i++)
                        {
                            Console.Write($"Enter step {i + 1}: ");
                            string description = Console.ReadLine();

                            recipe.SetStep(i, description);
                        }

                        Console.WriteLine("New Recipe:");
                        recipe.PrintRecipe();
                        break;
                    // User closed the console application 
                    case 4:
                        return;
                }
            }
        }
    }
}