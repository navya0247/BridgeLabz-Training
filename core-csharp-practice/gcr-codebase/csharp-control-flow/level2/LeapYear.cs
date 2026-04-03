using System;
class LeapYear{
	static void Main(String[]args){
		
		//take year from user
		int year=int.Parse(Console.ReadLine());
		
		//check wheather the year is valid
		if(year<1582){
			Console.WriteLine("Year must be 1582 or later");
		}
		
		//check for the leap year
		else{
			if(year%400==0){
					Console.WriteLine("Year is a Leap Year");
			}
			else if(year%100==0){
				Console.WriteLine("Year is not a Leap Year");
			}
			else if(year%4==0){
				Console.WriteLine("Year is a Leap Year");
			}
			else{
				Console.WriteLine("Year is not a Leap Year");
			}
		}
	}
}