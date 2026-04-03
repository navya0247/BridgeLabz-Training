using System;
class FindDiscount{
	public static void Main(String[]args){
		int fee=125000;                               //student's fee
		int discountPercent=10;                       // discount offering by university
		int amount=(fee*discountPercent)/100;         //calculate the discounted amount
		int discountedFee=fee-amount;                 // calculate the price the student will pay
		Console.WriteLine("The discount amount is INR " +amount+ " and final discounted fee is INR "+discountedFee);
	}
}
		
		