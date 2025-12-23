using System;
class NaturalNo{
	static void Main(String[]args){
		
		//take no as input from user
		int number=int.Parse(Console.ReadLine());
		
		//check the no if natural and find the sum
		if(number>0){
			int sum=number*(number+1)/2;
			Console.WriteLine("The sum of "+ number +" natural numbers is "+ sum);
		}
		else{
			Console.WriteLine("The number "+ number +" is not a natural number");
		}
	}
}	