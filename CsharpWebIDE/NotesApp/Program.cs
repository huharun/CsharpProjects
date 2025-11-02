using System;
using System.Collections.Generic;

namespace NotesApp
{
    public class Program
    {
        private static List<string> notes = new List<string>();

        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("🗒 Notes App Mini Project");
                Console.WriteLine("1. Add Note");
                Console.WriteLine("2. View Notes");
                Console.WriteLine("3. Delete Note");
                Console.WriteLine("0. Return to Dashboard");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter note: ");
                        string note = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(note)) notes.Add(note);
                        else Console.WriteLine("Invalid note!");
                        break;

                    case "2":
                        if (notes.Count == 0) Console.WriteLine("No notes yet.");
                        else for (int i = 0; i < notes.Count; i++)
                                Console.WriteLine($"{i + 1}. {notes[i]}");
                        break;

                    case "3":
                        Console.Write("Enter note number to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= notes.Count)
                            notes.RemoveAt(num - 1);
                        else Console.WriteLine("Invalid number!");
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
