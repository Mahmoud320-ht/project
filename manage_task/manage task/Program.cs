using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string command = "";

        Console.WriteLine("Welcome to the To-Do List App!");

        while (command != "exit")
        {
            Console.WriteLine("\nPlease enter a command (add, list, remove, exit):");
            command = Console.ReadLine();

            switch (command.ToLower())
            {
                case "add":
                    Console.WriteLine("Enter the task you want to add:");
                    string taskToAdd = Console.ReadLine();
                    tasks.Add(taskToAdd);
                    Console.WriteLine($"Task '{taskToAdd}' added.");
                    break;

                case "list":
                    Console.WriteLine("Your tasks:");
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks available.");
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                    }
                    break;

                case "remove":
                    Console.WriteLine("Enter the number of the task you want to remove:");
                    int taskNumber;
                    if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
                    {
                        string removedTask = tasks[taskNumber - 1];
                        tasks.RemoveAt(taskNumber - 1);
                        Console.WriteLine($"Task '{removedTask}' removed.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    break;

                case "exit":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }
    }
}

