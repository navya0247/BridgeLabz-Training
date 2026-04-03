using System;
class CalcTemp{
	public static void Main(String[]args){
		double celsius=double.Parse(Console.ReadLine());          //take temperature in celsius from user
		double fahrenheit=(celsius*9/5)+32;                       //convert celsius into fahrenheit
		Console.WriteLine("The " + celsius +" Celsius is "+ fahrenheit +" Fahrenheit");
	}
}	