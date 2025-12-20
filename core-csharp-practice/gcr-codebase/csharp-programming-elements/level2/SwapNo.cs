using System;
class SwapNo{
	public static void Main(String[]args){
		int num1=int.Parse(Console.ReadLine());                    //take first no from user
		int num2=int.Parse(Console.ReadLine());                    //take second no from user
		int temp=num1;                                             //stores the first no in temp
		 num1=num2;                                             //assign second no to first no
		 num2=temp;                                             //assign temp  to second no
		Console.WriteLine("The swapped numbers are "+ num1 +" and " + num2);
	}
}