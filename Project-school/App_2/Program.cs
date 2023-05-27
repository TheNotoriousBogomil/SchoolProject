using System;
using System.Collections.Generic;

class ProjectManagementSystem
{
    static List<Project> projects = new List<Project>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Project Management System");
            Console.WriteLine("1. Create Project");
            Console.WriteLine("2. View Projects");
            Console.WriteLine("3. Manage Tasks");
            Console.WriteLine("4. Manage Resources");
            Console.WriteLine("5. Communication and Collaboration");
            Console.WriteLine("6. Statistics and Analysis");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    CreateProject();
                    break;
                case 2:
                    ViewProjects();
                    break;
                case 3:
                    ManageTasks();
                    break;
                case 4:
                    ManageResources();
                    break;
                case 5:
                    CommunicationCollaboration();
                    break;
                case 6:
                    StatisticsAnalysis();
                    break;
                case 7:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateProject()
    {
        Console.Write("Enter project name: ");
        string name = Console.ReadLine();

        Console.Write("Enter project description: ");
        string description = Console.ReadLine();

        Console.Write("Enter project deadline: ");
        DateTime deadline = DateTime.Parse(Console.ReadLine());

        Project project = new Project(name, description, deadline);
        projects.Add(project);

        Console.WriteLine("Project created successfully!");
    }

    static void ViewProjects()
    {
        if (projects.Count == 0)
        {
            Console.WriteLine("No projects found.");
            return;
        }

        Console.WriteLine("Project List:");
        foreach (Project project in projects)
        {
            Console.WriteLine(project);
        }
    }

    static void ManageTasks()
    {
        Console.Write("Enter project name: ");
        string projectName = Console.ReadLine();

        Project project = projects.Find(p => p.Name == projectName);

        if (project == null)
        {
            Console.WriteLine("Project not found.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Task Management");
            Console.WriteLine("1. Create Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Go Back");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    project.CreateTask();
                    break;
                case 2:
                    project.ViewTasks();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ManageResources()
    {
        Console.Write("Enter project name: ");
        string projectName = Console.ReadLine();

        Project project = projects.Find(p => p.Name == projectName);

        if (project == null)
        {
            Console.WriteLine("Project not found.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Resource Management");
            Console.WriteLine("1. Add Resource");
            Console.WriteLine("2. Remove Resource");
            Console.WriteLine("3. View Resources");
            Console.WriteLine("4. Go Back");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    project.AddResource();
                    break;
                case 2:
                    project.RemoveResource();
                    break;
                case 3:
                    project.ViewResources();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CommunicationCollaboration()
    {
        Console.Write("Enter project name: ");
        string projectName = Console.ReadLine();

        Project project = projects.Find(p => p.Name == projectName);

        if (project == null)
        {
            Console.WriteLine("Project not found.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Communication and Collaboration");
            Console.WriteLine("1. Send Message");
            Console.WriteLine("2. Schedule Meeting");
            Console.WriteLine("3. Share Document");
            Console.WriteLine("4. Go Back");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    project.SendMessage();
                    break;
                case 2:
                    project.ScheduleMeeting();
                    break;
                case 3:
                    project.ShareDocument();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void StatisticsAnalysis()
    {
        Console.Write("Enter project name: ");
        string projectName = Console.ReadLine();

        Project project = projects.Find(p => p.Name == projectName);

        if (project == null)
        {
            Console.WriteLine("Project not found.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Statistics and Analysis");
            Console.WriteLine("1. Generate Report");
            Console.WriteLine("2. Analyze Progress");
            Console.WriteLine("3. Go Back");

            Console.Write("Select an option: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    project.GenerateReport();
                    break;
                case 2:
                    project.AnalyzeProgress();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

class Project
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public List<Task> Tasks { get; set; }
    public List<string> Resources { get; set; }

    public Project(string name, string description, DateTime deadline)
    {
        Name = name;
        Description = description;
        Deadline = deadline;
        Tasks = new List<Task>();
        Resources = new List<string>();
    }

    public void CreateTask()
    {
        Console.Write("Enter task name: ");
        string name = Console.ReadLine();

        Console.Write("Enter task description: ");
        string description = Console.ReadLine();

        Console.Write("Enter task deadline: ");
        DateTime deadline = DateTime.Parse(Console.ReadLine());

        Task task = new Task(name, description, deadline);
        Tasks.Add(task);

        Console.WriteLine("Task created successfully!");
    }

    public void ViewTasks()
    {
        if (Tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        Console.WriteLine("Task List:");
        foreach (Task task in Tasks)
        {
            Console.WriteLine(task);
        }
    }

    public void AddResource()
    {
        Console.Write("Enter resource name: ");
        string resourceName = Console.ReadLine();

        Resources.Add(resourceName);

        Console.WriteLine("Resource added successfully!");
    }

    public void RemoveResource()
    {
        Console.Write("Enter resource name: ");
        string resourceName = Console.ReadLine();

        if (Resources.Remove(resourceName))
        {
            Console.WriteLine("Resource removed successfully!");
        }
        else
        {
            Console.WriteLine("Resource not found.");
        }
    }

    public void ViewResources()
    {
        if (Resources.Count == 0)
        {
            Console.WriteLine("No resources found.");
            return;
        }

        Console.WriteLine("Resource List:");
        foreach (string resource in Resources)
        {
            Console.WriteLine(resource);
        }
    }

    public void SendMessage()
    {
        Console.Write("Enter message: ");
        string message = Console.ReadLine();

        Console.WriteLine("Message sent successfully!");
    }

    public void ScheduleMeeting()
    {
        Console.Write("Enter meeting details: ");
        string meetingDetails = Console.ReadLine();

        Console.WriteLine("Meeting scheduled successfully!");
    }

    public void ShareDocument()
    {
        Console.Write("Enter document name: ");
        string documentName = Console.ReadLine();

        Console.WriteLine("Document shared successfully!");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating project report...");

        // Generate and display report
    }

    public void AnalyzeProgress()
    {
        Console.WriteLine("Analyzing project progress...");

        // Perform analysis and display results
    }

    public override string ToString()
    {
        return $"Name: {Name}\nDescription: {Description}\nDeadline: {Deadline}";
    }
}

class Task
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }

    public Task(string name, string description, DateTime deadline)
    {
        Name = name;
        Description = description;
        Deadline = deadline;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nDescription: {Description}\nDeadline: {Deadline}";
    }
}

