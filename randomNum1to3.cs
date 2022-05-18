using System;

namespace randomNumber1To3
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Guess what the number is ");
            int user_input = Convert.ToInt32(Console.ReadLine());

            if (user_input == correctNumber)
            {
                Console.WriteLine("You get the correct answer!");
            }
            else if (user_input > correctNumber)
            {
                if(user_input > 3)
                {
                    Console.WriteLine("Out of range");
                }
                Console.WriteLine("Too high");
            }
            else if (user_input < correctNumber) {
                if (user_input < 1)
                {
                    Console.WriteLine("Out of range");
                }
                Console.WriteLine("Too low");
            }

        }
    }
}