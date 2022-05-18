using System;

namespace App
{ 
    public class CopyArray
    {
        public static void Main()
        {
        string[] plants = { "Lily", "Daisy", "Sunny", "Rainy", "Rosemary", "Mint", "Garlic", "Pepper", "Cloudy", "Mountain" };
        Console.WriteLine(plants);

        string[] plants2 = { "Lily", "Daisy", "Sunny", "Rainy", "Rosemary", "Mint", "Garlic", "Pepper", "Cloudy", "Mountain" };
            Console.WriteLine(plants2.Length);

            foreach (string plantations in plants)
            {
                Console.WriteLine(plantations);
            }
        }

    }
    
}