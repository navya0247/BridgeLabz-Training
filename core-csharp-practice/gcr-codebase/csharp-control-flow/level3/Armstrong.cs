using System;
class Armstrong{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		int sum=0;
		
		int originalNumber=number;
		
		while(originalNumber!=0){
			int rem=originalNumber%10;                         //get last digit
			sum=sum+(rem*rem*rem);                             // cube and add
			 originalNumber=originalNumber/10;             //remove last digit
		}
		if(sum==number){
			Console.WriteLine("Armstrong Number");
		}
		else{
			Console.WriteLine("Not an Armstrong Number");
		}
	}
}
			