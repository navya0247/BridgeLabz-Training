using System;
class Vote{
	static void Main(String[]args){
		
		//take age from user
		int age=int.Parse(Console.ReadLine());
		
		//check wheather the person is eligible for vote or not
		if(age>=18){
			Console.WriteLine("The person's age is "+ age +" and can vote");
		}
		else{
			Console.WriteLine("The person's age is "+ age + " and cannot vote");
		}
	}
}