using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class Program
    {
        private static List<string> tasks = new List<string>();

        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("📝 ToDo App Mini Project");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("0. Return to Dashboard");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task: ");
                        string task = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(task))
                        {
                            tasks.Add(task);
                            Console.WriteLine("Task added!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Tasks:");
                        if (tasks.Count == 0) Console.WriteLine("No tasks yet.");
                        else
                        {
                            for (int i = 0; i < tasks.Count; i++)
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                        break;

                    case "3":
                        Console.Write("Enter task number to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= tasks.Count)
                        {
                            Console.WriteLine($"Removed: {tasks[num - 1]}");
                            tasks.RemoveAt(num - 1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid number!");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
