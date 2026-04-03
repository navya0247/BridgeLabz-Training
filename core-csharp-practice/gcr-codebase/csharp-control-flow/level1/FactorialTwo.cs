using System;
class Factorial{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//check number is natural 
		if(number>0){
			
		//initialize factorial as 1 
		int fact=1;
		
		for(int i=number;i>=1;i--){                        // for loop to calculate the factorial
			fact=fact*i;			
			
		}
		Console.WriteLine("The Factorial of a number is "+fact);
	}
}
}