using System;
class Calculator{
	public static void Main(String[]args){
		float number1=float.Parse(Console.ReadLine());           //take first no from user
		float number2=float.Parse(Console.ReadLine());           //take second no from user
		float adds=number1+number2;                            //perform addition
		float subs=number1-number2;                            //perform subtraction
		float mult=number1*number2;                            //perform mult
		float division=number1/number2;                        //perform division
		Console.WriteLine("The addition,subtraction,multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+adds+", "+ subs+", "+mult+", "+" and "+ division);
	}
}
		

		