using System;
class Digits{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		int count=0;
		
	    // Loop until number becomes 0

		while(number!=0){
			number=number/10;               // remove last digit
			count++;                        // increase count
		}
		Console.WriteLine("Number of digits "+count);
	}
}