using System;
class Sum{
	static void Main(String[]args){
		
		double total=0.0;
		
		//take first input
		double values=double.Parse(Console.ReadLine());
		
		// Loop until user enters 0
		while(values!=0){
			total=total+values;                           // add to total
			 values=double.Parse(Console.ReadLine());     //take input again
		}
		Console.WriteLine("The total sum is " +total);
	}
}
			