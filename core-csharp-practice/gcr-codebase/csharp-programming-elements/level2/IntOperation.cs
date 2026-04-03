using System;
class IntOperation{
	public static void Main(String[]args){
		int a=int.Parse(Console.ReadLine());                //take variable a  from user
		int b=int.Parse(Console.ReadLine());                //take variable b  from user
		int c=int.Parse(Console.ReadLine());                //take variable c from user
		int d=a+b*c;                                        //calculate first operation
		int e=a*b+c;                                        //calculate second operation
		int f=c+a/b;                                        //calculate third operation
		int g=a%b+c;                                        //calculate fourth operation
		Console.WriteLine("The results of Int Operations are "+ d +","+e+" ,"+f+" and "+g);
	}
}