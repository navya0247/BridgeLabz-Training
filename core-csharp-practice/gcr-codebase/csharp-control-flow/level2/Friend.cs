using System;
class Friend{
	static void Main(String[] args){
		
		//take age input from user
		int amarAge=int.Parse(Console.ReadLine());
		
		int akbarAge=int.Parse(Console.ReadLine());
		
		int anthonyAge=int.Parse(Console.ReadLine());
		
		//take height input from user
		double amarHeight=double.Parse(Console.ReadLine());
		double akbarHeight=double.Parse(Console.ReadLine());
		double anthonyHeight=double.Parse(Console.ReadLine());
		
		//check for the youngest among 3
		if(amarAge<akbarAge && amarAge<anthonyAge){
			Console.WriteLine("Amar is Youngest");
		}
	 else if(akbarAge<amarAge && akbarAge<anthonyAge){
			Console.WriteLine("Akbar is Youngest");
		}
		else{
			Console.WriteLine("Anthony is Youngest");
		}
		
		//check for the tallest among 3
		
		if(amarHeight<akbarHeight && amarHeight>anthonyHeight){
			Console.WriteLine("Amar is Tallest");
		}
	 else if(akbarHeight>amarHeight && akbarHeight>anthonyHeight){
			Console.WriteLine("Akbar is Tallest");
		}
		else{
			Console.WriteLine("Anthony is Tallest");
		}
	}
}
		
		
		