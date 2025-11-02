using System;

namespace Calculator
{
    public class Program
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("🖥 Calculator Mini Project");
                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("0. Return to Dashboard");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                if (choice == "0") break;

                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Invalid number. Press Enter...");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Invalid number. Press Enter...");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case "1": Console.WriteLine($"Result: {a + b}"); break;
                    case "2": Console.WriteLine($"Result: {a - b}"); break;
                    case "3": Console.WriteLine($"Result: {a * b}"); break;
                    case "4":
                        if (b == 0) Console.WriteLine("Cannot divide by zero!");
                        else Console.WriteLine($"Result: {a / b}");
                        break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
