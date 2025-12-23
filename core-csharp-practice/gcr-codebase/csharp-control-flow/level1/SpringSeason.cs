using System;
class SpringSeason{
	static void Main(String[]args){
		
		//take month from user
		int month=int.Parse(Console.ReadLine());
		
		//take day from user
		int day=int.Parse(Console.ReadLine());
		
		//check wheather the season is spring or not
		if((month==3 && day>=20) ||(month==4)||(month==5)|| (month==6 &&day<=20)){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}