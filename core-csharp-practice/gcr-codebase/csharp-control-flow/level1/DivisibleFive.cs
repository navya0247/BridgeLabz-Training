using System;
class DivisibleFive{
	static void Main(String[]args){
		//input number from user
		int number=int.Parse(Console.ReadLine());
		
		//check if the number divisible by five
		if(number%5==0){
			Console.WriteLine("The number is divisible by 5");
		}
		else{
			Console.WriteLine("The number is not divisible by 5");
		}
	}
}
		