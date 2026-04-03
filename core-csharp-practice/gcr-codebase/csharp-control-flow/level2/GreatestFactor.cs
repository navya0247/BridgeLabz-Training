using System;
class GreatestFactor{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		//assign 1 to greatest Factor
		int greatestFactor=1;
		
		//check for greatest factor  beside the number itself
		for(int i=number-1;i>=1;i--){
			if(number%i==0){
				greatestFactor=i;
				break;
			}
		}
		Console.WriteLine("Greatest Factor variable is "+greatestFactor);
	}
}