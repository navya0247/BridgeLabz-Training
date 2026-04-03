using System;
class KmToMiles{
	public static void Main(String[]args){
		double km=double.Parse(Console.ReadLine());                     //take distance in km from user                                          //take distance in km
		double mile= km/1.6;                                            //convert  km into miles 
		Console.WriteLine("The total miles is " +mile+ " mile for the given "+km +"km");
	}
}