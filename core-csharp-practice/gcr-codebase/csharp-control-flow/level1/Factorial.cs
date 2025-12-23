using System;
class Factorial{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//initialize factorial as 1 
		int fact=1;
		
		//assign number to i 
		int i=number;
		while(i>=1){                        //loop to calculate the factorial
			fact=fact*i;			
			i--;
		}
		Console.WriteLine("The Factorial of a number is "+fact);
	}
}