using System;
class SI{
	public static void Main(String[]args){
		int principal=int.Parse(Console.ReadLine());            //take principal as input from user
		int rate=int.Parse(Console.ReadLine());                 //take rate as input from user
		int time=int.Parse(Console.ReadLine());                 //take time as input from user
		int simpleInterest=(principal*rate*time)/100;           //calculate the simple interest
		Console.WriteLine("The Simple Interest is " + simpleInterest +"for Principal "+ principal +" , Rate of Interest "+ rate +"and Time "+time);
	}
}