using System;
class NoPositive{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
				
		//check no is positive
		if(number>0){
		Console.WriteLine("The number is positive");
	}
	
	//check no is negative
	else if(number<0){
		Console.WriteLine("The number is negative");
	}
	
	//check no is zero
	else{
		Console.WriteLine("The number is zero");
	}
	}
}