using System;
class TotalIncome{
	public static void Main(String[]args){
		int salary=int.Parse(Console.ReadLine());                    //take salary as input from user
		int bonus=int.Parse(Console.ReadLine());                     //take bonus as input from user
		int totalIncome=salary+bonus;                                //calculate the total income
		Console.WriteLine("The salary is INR "+ salary +" and bonus is INR "+ bonus +". Hence Total Income is INR "+ totalIncome );
	}
}