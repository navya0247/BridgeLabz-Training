using System;
class MaxHandshake{
	public static void Main(String[]args){
		int n=int.Parse(Console.ReadLine());                               //take no of students from user
        int maxHandshake=(n*(n-1))/2;                                      //calculate the max no of handshakes
		Console.WriteLine("The maximum number of Handshake is "+maxHandshake+" while number of students is "+n);
	}
}