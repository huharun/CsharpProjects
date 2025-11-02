using System;

namespace QuizGame
{
    public class Program
    {
        public static void Run()
        {
            var questions = new[]
            {
                new { Q = "What is 2+2?", A = "4" },
                new { Q = "Capital of France?", A = "Paris" },
                new { Q = "C# is a ___ language?", A = "Programming" }
            };

            int score = 0;
            Console.Clear();
            Console.WriteLine("📝 Quiz Game Mini Project");

            foreach (var q in questions)
            {
                Console.WriteLine(q.Q);
                Console.Write("Answer: ");
                if (Console.ReadLine()?.Trim().ToLower() == q.A.ToLower()) 
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else Console.WriteLine($"Wrong! Answer: {q.A}");
            }

            Console.WriteLine($"Your score: {score}/{questions.Length}");
            Console.WriteLine("Press Enter to return to dashboard...");
            Console.ReadLine();
        }
    }
}
