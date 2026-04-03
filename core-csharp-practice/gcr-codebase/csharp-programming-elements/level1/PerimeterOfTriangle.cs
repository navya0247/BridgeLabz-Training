using System;
class PerimeterOfTriangle{
	public static void Main(String[]args){
		double peri=double.Parse(Console.ReadLine());             //take perimeter from user
        double side=peri/4;                                      //calculate the side of square
		Console.WriteLine("The length of the side is "+side+" whose perimeter is "+peri);
	}
}