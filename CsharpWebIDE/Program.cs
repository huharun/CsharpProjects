using System;

class Dashboard
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("🖥 C# Mini Projects Dashboard");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. ToDo App");
            Console.WriteLine("3. Guess Number");
            Console.WriteLine("4. Quiz Game");
            Console.WriteLine("5. Notes App");
            Console.WriteLine("0. Exit");
            Console.Write("Select a project: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Calculator.Program.Run(); break;
                case "2": ToDoApp.Program.Run(); break;
                case "3": GuessNumber.Program.Run(); break;
                case "4": QuizGame.Program.Run(); break;
                case "5": NotesApp.Program.Run(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice, press Enter..."); Console.ReadLine(); break;
            }
        }
    }
}
