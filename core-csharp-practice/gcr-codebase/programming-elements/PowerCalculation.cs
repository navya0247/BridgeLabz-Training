using System;
class PowerCalculation{
	public static void Main(String[]args){
		int baseNum=2;                                               //take base as input
		int exponent=4;                                           //take exponent as input
		double result=Math.Pow(baseNum,exponent);                       //calculate base raised to the exponent
		Console.WriteLine("Result is:" + result);
	}
}