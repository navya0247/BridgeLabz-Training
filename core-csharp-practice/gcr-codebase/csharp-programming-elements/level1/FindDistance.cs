using System;
class FindDistance{
	public static void Main(String[]args){
		double distFeet=double.Parse(Console.ReadLine());             //take distance from feet
        double distYard=distFeet/3;                                   //calculate distance in yards
		double distMile=distYard/1760;                                //calculate distance in mile
		Console.WriteLine("Distance in feet is "+distFeet+" while in yards is "+distYard+" while in miles is "+distMile );
	}
}