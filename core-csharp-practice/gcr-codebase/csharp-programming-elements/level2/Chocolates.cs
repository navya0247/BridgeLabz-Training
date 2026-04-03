using System;
class Chocolates{
	public static void Main(String[]args){
		int chocolates=int.Parse(Console.ReadLine());                   //take no of chocolates from user
		int children=int.Parse(Console.ReadLine());                     //take no of children from user
		int getChocolate=chocolates/children;                           //calculate the chocolate each children can get
		int remChocolate=chocolates%children;                             //calculate the remaining no of chocolates
		Console.WriteLine("The number of chocolates each child gets is "+ getChocolate +" and the number of remaining chocolates is "+remChocolate);
	}
}
		