using System;
class Factor{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		//check for the factor beside the number itself
		for(int i=1;i<number;i++){
			if(number%i==0){
				Console.WriteLine(i);
			}
		}
	}
}