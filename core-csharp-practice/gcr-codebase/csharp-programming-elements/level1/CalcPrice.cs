using System;
class CalcPrice{
	public static void Main(String[]args){
		double price=double.Parse(Console.ReadLine());             //take price of an item from user
        int quantity=int.Parse(Console.ReadLine());                //take quantity from user
		double totalPrice=price*quantity;                          // calculate the total price
		Console.WriteLine("The total purchase price is INR "+totalPrice+" if the quantity "+quantity+" and unit price is INR "+price);
	}
}