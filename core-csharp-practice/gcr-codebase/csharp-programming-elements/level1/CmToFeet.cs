using System;
class CmToFeet{
	public static void Main(String[]args){
		double height=double.Parse(Console.ReadLine());          //take height from user
		double inch=height/2.54;                              //convert height into inch
		double foot=inch/12;                                  //convert inch into foot
		Console.WriteLine("Your Height in cm is "+height+" while in feet is "+foot+" and inches is " +inch);
	}
}	