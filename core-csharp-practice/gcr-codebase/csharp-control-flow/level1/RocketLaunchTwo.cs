using System;
class RocketLaunchTwo{
	static void Main(String[]args){
		
		//take counter from the user
		int counter=int.Parse(Console.ReadLine());
		
		//countdown the number to 1 and decrement the counter
		for(int i=counter; i>=1;i--){
			Console.WriteLine("The counter is "+i);
		}
	}
}