using System;
class Sum{
	static void Main(String[]args){
		
		double total=0.0;
		
		while(true){
		
		//Take input from user
		double values=double.Parse(Console.ReadLine());
		
		
         //Check for 0 or negative number
		if(values<=0){
			break;
		}
		
		 //Add value to total
		total=total+values;
		
		}
		Console.WriteLine("The total sum is "+total);
	
	}
}
			