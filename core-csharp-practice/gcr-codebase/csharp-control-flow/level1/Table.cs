using System;
class Table{
	static void Main(String[]args){
		
		//take number from user
		int number=int.Parse(Console.ReadLine());
		
		//iterate the no between 6 to 9 and print the table
		for(int i=6;i<=9;i++){
			Console.WriteLine(number+" * "+ i +" = "+ number*i);
		}
	}
}
		