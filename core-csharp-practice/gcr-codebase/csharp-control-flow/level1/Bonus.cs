using System;
class Bonus{
	static void Main(String[]args){
		
		//take salary from user
		double salary=double.Parse(Console.ReadLine());
		
		//take year Of Service from user
		int yearOfService=int.Parse(Console.ReadLine());
		
		double bonus=0;
		
		//check if year Of Service gives bonus or not
		if(yearOfService>5){
			 bonus=salary*0.05;
		}
		Console.WriteLine("Bonus of Employees is "+bonus);
	}
}