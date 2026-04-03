using System;
class IntOperation{
	public static void Main(String[]args){
		double a=double.Parse(Console.ReadLine());                //take variable a  from user
		double b=double.Parse(Console.ReadLine());                //take variable b  from user
		double c=double.Parse(Console.ReadLine());                //take variable c from user
		double d=a+b*c;                                        //calculate first operation
		double e=a*b+c;                                        //calculate second operation
		double f=c+a/b;                                        //calculate third operation
		double g=a%b+c;                                        //calculate fourth operation
		Console.WriteLine("The results of Int Operations are "+ d +","+e+" ,"+f+" and "+g);
	}
}