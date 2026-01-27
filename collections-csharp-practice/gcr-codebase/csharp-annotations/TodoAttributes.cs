using System;
using System.Reflection;

namespace BridgeLabzTraining.Collections.Annotations
{
    // Custom Attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class TodoAttribute : Attribute
    {
        public string Task { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; } = "MEDIUM";

        // Constructor name must match class name
        public TodoAttribute(string task, string assignedTo)
        {
            Task = task;
            AssignedTo = assignedTo;
        }
    }

    class Project
    {
        [Todo("Add login", "Navya", Priority = "HIGH")]
        [Todo("Improve UI", "Rahul")]
        public void Features() { }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            MethodInfo method = typeof(Project).GetMethod("Features");

            var todos = method.GetCustomAttributes(typeof(TodoAttribute), false);

            foreach (TodoAttribute t in todos)
            {
                Console.WriteLine($"{t.Task} | {t.AssignedTo} | {t.Priority}");
            }
        }
    }
}
