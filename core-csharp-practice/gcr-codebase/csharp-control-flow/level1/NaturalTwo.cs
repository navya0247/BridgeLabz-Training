using System;
class NaturalTwo{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//check the number is natural
		if(number>0){
			int sum=0;
			int i=1;
		while(i<=number){                          //Compute the sum using while loop
			sum=sum+i;
			i++;
		}
		
		//Compute the sum using formula
		int sumFormula=number*(number+1)/2;
		Console.WriteLine("Sum using While Loop "+sum);
		Console.WriteLine("Sum using Formula" + sumFormula);
		
		//check if sum using while loop is equal to the sum using formula
		if(sum==sumFormula){
			Console.WriteLine("Both the Computations are equal");
		}
		else{
			Console.WriteLine("Both the Computations are are equal");
		}
		}
	}
}	