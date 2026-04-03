using System;
	class PrimeNo{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
	      
		//take boolean prime as true
		bool isPrime=true;
		if(number<=1){                        //check for the no is not prime
			isPrime=false;
		}
		else{
			
		for(int i=2;i<number;i++){           //use the iteration to check some other number divides or not the provided number
			if(number%i==0){
				isPrime=false;
				break;
			}
		}
		}
		if(isPrime){
			Console.WriteLine("Number is a Prime number");
		}
		else{
			Console.WriteLine("Number is not a prime number");
		}
	}
}
			
			