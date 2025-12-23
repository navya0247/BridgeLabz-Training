using System;
class Power{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		int power=int.Parse(Console.ReadLine());
		
		//assign 1 to result
		int result=1;
		
		//loop to calculate the power
		for(int i=1;i<=power;i++){
			result=result*number;
		}
		Console.WriteLine("Power of a number is"+result);
	}
}
		
		