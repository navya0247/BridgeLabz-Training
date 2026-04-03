using System;
	class Bmi{
	static void Main(String[]args){
		
		//take input from user
		double weight=double.Parse(Console.ReadLine());
		
		double height=double.Parse(Console.ReadLine());
		
		//convert height from cm to meter
		double heightM=height/100;
		
		//calculate bmi
		double bmi=weight/(heightM*heightM);
		Console.WriteLine("BMI Is "+bmi);
		
		//determine weight status
		if(bmi<=18.4){
			Console.WriteLine("UnderWeight");
		}
		
		else if(bmi>=18.5 && bmi<=24.9){
			Console.WriteLine("Normal");
		}
		else if(bmi>=25.0 && bmi<=39.9){
			Console.WriteLine("Overweight");
		}
		else{
			Console.WriteLine("Obese");
		}
	}
	}
			
		
		
			
		