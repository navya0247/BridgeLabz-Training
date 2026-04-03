using System;
class AreaOfTriangle{
	public static void Main(String[]args){
		double bas=double.Parse(Console.ReadLine());             //take base of triangle from user
        double height=double.Parse(Console.ReadLine());         //take height of triangle from user
		double area=0.5*bas*height;                            //calculate the area in square centimeters
		double areaInches=area/2.54;                             //calculate the area in inches
		double areaFeet=areaInches/12;                           //calculate the area in feet
		Console.WriteLine("Area of triangle in cm is "+area+" while in feet is "+areaFeet+" and inches is "+areaInches);
	}
}
		
		