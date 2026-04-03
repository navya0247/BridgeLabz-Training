using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.collections.annotations
{
   
[AttributeUsage(AttributeTargets.Method)]
    class ImportantMethodAttribute : Attribute
    {
        public string Level { get; set; }

        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }

    class Service
    {
        [ImportantMethod]
        public void SaveData() { }

        [ImportantMethod("LOW")]
        public void LogData() { }
    }

    internal class ImportantMethod
    {
        public static void Main(string[] args)
        {
            foreach (MethodInfo m in typeof(Service).GetMethods())
            {
                var attr = (ImportantMethodAttribute)
                    Attribute.GetCustomAttribute(m, typeof(ImportantMethodAttribute));

                if (attr != null)
                {
                    Console.WriteLine($"{m.Name} - Level: {attr.Level}");
                }
            }
        }
    }
}

