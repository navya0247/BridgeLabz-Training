using System;
	class Rounds{
		public static void Main(String[] args){
			int side1=int.Parse(Console.ReadLine());                //take first side of triangle from user
			int side2=int.Parse(Console.ReadLine());                 //take second side of triangle from user
			int side3=int.Parse(Console.ReadLine());                  //take third side of triangle from user
			int distance=5000;                                           //distance in meters
			int perimeter=side1+side2+side3;                         //calculate the perimeter
			int rounds=distance/perimeter;                           //calculate the rounds completed by athlete
			Console.WriteLine("The total number of rounds the athlete will run is "+ rounds +" to complete 5 km");
		}
}
