using System;
class Largest{
	static void Main(String[]args){
		
		//take three numbers from user
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		int number3=int.Parse(Console.ReadLine());
		
		//check if number1 is largest of three
		if(number1>number2 && number1>number3){
			Console.WriteLine("Number1 is largest of the three");
		}
		
		//check if number2 is largest of three
		else if(number2>number1 && number2>number3){
			Console.WriteLine("Number2 is largest of the three");
		}
		
		//check if number3 is largest of three
		else if(number3>number1 && number3>number2){
			Console.WriteLine("Number3 is largest of the three");
		}
	}
}
		
		