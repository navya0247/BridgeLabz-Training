using System;
class AbundantNo{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		//Variable to store sum of divisors
		int sum=0;
		
		   //Loop from 1 to less than the number
		for(int i=1;i<number;i++){
			
			//Check if i is a divisor of number
			if(number%i==0){
				sum=sum+i;
			}
		}
		
		 //Check if sum of divisors is greater than the number
		if(sum>number){
			Console.WriteLine("Number is Abundant Number");
		}
		
		else{
			Console.WriteLine("Number is  not an Abundant Number");
		}
	}
}
				