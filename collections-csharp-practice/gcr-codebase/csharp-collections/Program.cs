using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

class Program
{
    public static void Main(String[] args)
    {
        Dictionary<int,string> dict=new Dictionary<int, string>();

Console.WriteLine("Enter the no of students");
int n=int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the roll no");
            int rollNo=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            string name=Console.ReadLine();

            dict[rollNo]=name;


        }

        Console.WriteLine("---student list---");

        foreach(var item in dict)
        {
            Console.WriteLine("Roll No:"+item.Key+"Name"+item.Value);
        }

        
    }
}
    