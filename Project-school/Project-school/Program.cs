using System;
using System.Collections.Generic;

class TaskManagementSystem
{
    static List<Task> tasks = new List<Task>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Task Management System");
            Console.WriteLine("1. Create Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Exit");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    DeleteTask();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateTask()
    {
        Console.Write("Enter task name: ");
        string name = Console.ReadLine();

        Console.Write("Enter task priority (High, Medium, Low): ");
        string priority = Console.ReadLine();

        Console.Write("Enter task due date: ");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Task task = new Task(name, priority, dueDate);
        tasks.Add(task);

        Console.WriteLine("Task created successfully!");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        Console.WriteLine("Task List:");
        foreach (Task task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void DeleteTask()
    {
        Console.Write("Enter the name of the task to delete: ");
        string name = Console.ReadLine();

        bool taskFound = false;
        for (int i = 0; i < tasks.Count; i++)
        {
            if (tasks[i].Name == name)
            {
                tasks.RemoveAt(i);
                Console.WriteLine("Task deleted successfully!");
                taskFound = true;
                break;
            }
        }

        if (!taskFound)
        {
            Console.WriteLine("Task not found.");
        }
    }
}

class Task
{
    public string Name { get; set; }
    public string Priority { get; set; }
    public DateTime DueDate { get; set; }

    public Task(string name, string priority, DateTime dueDate)
    {
        Name = name;
        Priority = priority;
        DueDate = dueDate;
    }


    public override string ToString()
    {
        return $"Name: {Name}, Priority: {Priority}, Due Date: {DueDate.ToShortDateString()}";
    }
}
