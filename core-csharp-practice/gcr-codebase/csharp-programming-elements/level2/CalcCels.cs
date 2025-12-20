using System;
class CalcCels{
	public static void Main(String[]args){
		double fahrenheit=double.Parse(Console.ReadLine());        //take temperature in fahrenheit from user
		double celsius=(fahrenheit-32)*5/9;                       //convert fahrenheit into celsius
		Console.WriteLine("The " + fahrenheit +" Fahrenheit is "+ celsius +" Celsius");
	}
}	