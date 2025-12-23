using System;
class HarshadNo{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		int sum=0;
		
		int originalNumber=number;
		
		 // Loop until number becomes 0
		while(number!=0){
			int rem=number%10;                        //get last digit
			sum=sum+rem;                              //add rem int the sum
			number=number/10;                        // remove last digit
		}
			if(originalNumber%sum==0){
				Console.WriteLine("Number is Harshad Number");
			}
			else{
				Console.WriteLine("Number is not Harshad Number");
			}
		
	}
}	