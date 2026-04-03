using System;
class CalcFee{
	public static void Main(String[]args){
		int fee=int.Parse(Console.ReadLine());                               // take fee from user
		int discountPercent=int.Parse(Console.ReadLine());                     // take discount from user
		int amount=(fee*discountPercent)/100;         //calculate the discounted amount
		int discountedFee=fee-amount;                 // calculate the price the student will pay
		Console.WriteLine("The discount amount is INR " +amount+ " and final discounted fee is INR "+discountedFee);
	}
}
		
		