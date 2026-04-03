using System;
class Weight{
	public static void Main(String[]args){
		double pounds=double.Parse(Console.ReadLine());             //take weight in pounds from user
		double kg=pounds/2.2;                                    //convert  pounds to kg
		Console.WriteLine("The weight of the person in pounds is "+ pounds +" and in kg is "+ kg);
	}
}