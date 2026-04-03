using System;
	class FizzBuzz{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//check for positive number
		if(number<=0){
			Console.WriteLine("Please enter a positive integer");
		}
		
		//applies the conditions as given using for loop
		else{
		for(int i=0;i<=number;i++){
			if(i%3==0 && i%5==0){
				Console.WriteLine("FizzBuzz");
			}
			else if(i%3==0){
				Console.WriteLine("Fizz");
			}
			else if(i%5==0){
				Console.WriteLine("Buzz");
			}
			else{
				Console.WriteLine(i);
			}
		}
		}
	}
	}