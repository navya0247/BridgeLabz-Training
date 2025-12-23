using System;
class OddEven{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//use loop to iterate between the numbers
		for(int i=1;i<=number;i++){
			if(i%2==0){                  //check the number is even
				Console.WriteLine("Even number is "+i);
			}
			else{
				Console.WriteLine("Odd number is "+i);
			}
		}
	}
}