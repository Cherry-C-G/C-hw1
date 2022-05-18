//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Print - a - Pyramid.Like the star pattern examples that we saw earlier, create a program that
//will print the following pattern: If you find yourself getting stuck, try recreating the two
//examples that we just talked about in this chapter first. They’re simpler, and you can
//compare your results with the code included above.
//This can actually be a pretty challenging problem, so here is a hint to get you going. I used
//three total loops. One big one contains two smaller loops. The bigger loop goes from line
//to line. The first of the two inner loops prints the correct number of spaces, while the
//second inner loop prints out the correct number of stars

using System;
public class Program
{
    public static void Main()
    {
        int i, j, n;

        Console.Write("\n\n");
        Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
        Console.Write("----------------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input number of rows for this pattern :");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            for (j = 1; j <= n - i; j++)
                Console.Write(" ");
            for (j = 1; j <= 2 * i - 1; j++)
                Console.Write("*");
            Console.Write("\n");
        }
    }
}
