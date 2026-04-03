using System;
class RocketLaunch{
	static void Main(String[]args){
		
		//take counter from the user
		int counter=int.Parse(Console.ReadLine());
		
		//countdown the number to 1 and decrement the counter
		while(counter>=1){
			Console.WriteLine("The counter is "+counter);
			counter--;
		}
	}
}
		