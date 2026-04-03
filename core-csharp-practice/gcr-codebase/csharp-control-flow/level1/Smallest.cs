using System;
class Smallest{
	static void Main(String[]args){
		
		//take three numbers from user
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		int number3=int.Parse(Console.ReadLine());
		
		//check if number first is less than from number2 and number3
		if(number1<number2 && number1<number3){
			Console.WriteLine("First Number is  smallest of the three number");
		}
		else{
			Console.WriteLine("First Number is not smallest of the three number");
		}
	}
}