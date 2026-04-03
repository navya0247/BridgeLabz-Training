using System;
class ProfitLossCalc{
	public static void Main(String[]args){
		int cost=129;                                    //take cost price as input
		int sell=191;                                    //take selling price as input
		double profit=sell-cost;                         //calculate the profit
		double profitPercentage=(profit/cost)*100;       //calculate the profit percentage
		Console.WriteLine("The Cost Price is INR "+cost+" and Selling Price is INR "+sell);
		Console.WriteLine("The Profit is INR "+profit+" and the Profit Percentage is "+profitPercentage);
	}
}