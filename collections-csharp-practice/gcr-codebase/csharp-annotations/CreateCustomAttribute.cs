using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections.annotations
{

[AttributeUsage(AttributeTargets.Method)]
    class TaskInfoAttribute : Attribute
    {
        public string Priority { get; set; }
        public string AssignedTo { get; set; }

        public TaskInfoAttribute(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }

    class TaskManager
    {
        [TaskInfo("High", "Navya")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed");
        }
    }

    internal class CreateCustomAttribute
    {
        public static void Main(string[] args)
        {
            MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");
            TaskInfoAttribute attr =
                (TaskInfoAttribute)Attribute.GetCustomAttribute(method, typeof(TaskInfoAttribute));

            Console.WriteLine("Priority: " + attr.Priority);
            Console.WriteLine("Assigned To: " + attr.AssignedTo);
        }
    }
}

