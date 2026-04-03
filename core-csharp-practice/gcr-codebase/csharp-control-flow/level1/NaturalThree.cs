using System;
class NaturalThree{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//check the number is natural
		if(number>0){
			int sum=0;
		for(int i=1;i<=number;i++){         //Compute the sum using for loop
			sum=sum+i;
		}
		
		//Compute the sum using formula
		int sumFormula=number*(number+1)/2;
		Console.WriteLine("Sum using for Loop "+ sum);
		Console.WriteLine("Sum using Formula " + sumFormula);
		
		//check if sum using for loop is equal to the sum using formula
		if(sum==sumFormula){
			Console.WriteLine("Both the Computations are equal");
		}
		else{
			Console.WriteLine("Both the Computations are are equal");
		}
		}
	}
}	