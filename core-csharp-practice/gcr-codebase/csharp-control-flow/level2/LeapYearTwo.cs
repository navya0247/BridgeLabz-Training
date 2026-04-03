using System;
class LeapYearTwo{
	static void Main(String[]args){
		
		//take year from user
		int year=int.Parse(Console.ReadLine());
		
		//check wheather the year is valid and check for the leap year
		
			if(year>=1582&& (year%400==0 ||(year%4==0 &&year%100!=0 ))){
					Console.WriteLine("Year is a Leap Year");
			}
			else{
				Console.WriteLine("Year is not a Leap Year");
			
		}
	}
}