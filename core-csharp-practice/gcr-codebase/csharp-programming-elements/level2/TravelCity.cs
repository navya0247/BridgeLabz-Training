using System;
class TravelCity
{
    public static void Main(string[] args)
    {
        
        string name = Console.ReadLine();                                      // Ask user to input their name
        
        string fromCity = Console.ReadLine();                                  // Ask user to input starting city 
        
        string viaCity = Console.ReadLine();                                    // Ask user to input via city
		
        string toCity = Console.ReadLine();                                     // Ask user to input destination city

        int fromToVia = int.Parse(Console.ReadLine());                           // Ask user to input distance from start to via city
        
        int timeTaken1 = int.Parse(Console.ReadLine());                           // Ask user to input time taken
       
        int viaToFinalCity = int.Parse(Console.ReadLine());                       // Ask user to input distance from via city to destination  
        int timeTaken2 = int.Parse(Console.ReadLine());                            // Ask user to input time taken

        int totalDis = fromToVia + viaToFinalCity;
        int totalTime = timeTaken1 + timeTaken2;

        Console.WriteLine(
            "The Total Distance travelled by " + name + " from " + fromCity + " to " + toCity + " via " + viaCity + " is " + totalDis +" km and the Total Time taken is " +totalTime + " hours");
    }
}