using System;

namespace GuessNumber
{
    public class Program
    {
        public static void Run()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            int attempts = 0;
            Console.Clear();
            Console.WriteLine("🎯 Guess the Number (1-100)");

            while (true)
            {
                Console.Write("Enter your guess (0 to exit): ");
                if (!int.TryParse(Console.ReadLine(), out int guess)) 
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (guess == 0) break;

                attempts++;
                if (guess < number) Console.WriteLine("Too low!");
                else if (guess > number) Console.WriteLine("Too high!");
                else
                {
                    Console.WriteLine($"Correct! Number: {number}, Attempts: {attempts}");
                    break;
                }
            }

            Console.WriteLine("Press Enter to return to dashboard...");
            Console.ReadLine();
        }
    }
}
