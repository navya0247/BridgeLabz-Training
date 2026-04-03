using System;
class Multiple{
	static void Main(String[]args){
		
		//take input from user
		int number=int.Parse(Console.ReadLine());
		
		//Loop from number to less than 100
		for(int i=number;i<100;i++){
			
			//Check if i is a multiple of number
			if(i%number==0){
				Console.WriteLine(i);
			}
		}
	}
}