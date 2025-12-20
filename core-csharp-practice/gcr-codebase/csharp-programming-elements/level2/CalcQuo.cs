using System;
class CalcQuo{
	public static void Main(String[]args){
		int num1=int.Parse(Console.ReadLine());                //take first no from user
		int num2=int.Parse(Console.ReadLine());                //take second no from user
		int quo=num1/num2;                                     //calculate the quotient
		int rem=num1%num2;                                     //calculate the remainder
		Console.WriteLine("The Quotient is "+quo+" and Remainder is "+rem+" of two numbers "+num1 +" and "+num2);
	}
}
		
