using Newtonsoft.Json;
using System;

class CreateStudentJson
{
    static void Main()
    {
        var student = new
        {
            name = "Navya",
            age = 22,
            subjects = new[] { "Maths", "AI", "ML" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}
