using System;
class Operators{
	static void Main(String[] args){
		//Arithmetic Operators
		int a=10;
		int b=8;
		Console.WriteLine(a+b);      //used for addition of two numbers
		Console.WriteLine(a-b);      //used for substraction of two numbers
		Console.WriteLine(a*b);      //used for multiplication of two numbers
		Console.WriteLine(a/b);      //divides the left operand by the right
		Console.WriteLine(a%b);      //returns the remainder of the division
		
		//Relational Operators
		Console.WriteLine(a==b);      //checks if two operands are equal
		Console.WriteLine(a!=b);      //checks if two operands are not equal
		Console.WriteLine(a>b);        //checks if left operand is greater than the right 
		Console.WriteLine(a<b);       //checks if left operand if less than the right
		Console.WriteLine(a>=b);      //checks if the left operand is greater than or equal to right
		Console.WriteLine(a<=b);      //checks if the left operand is less than or equal to right
		
		//Logical Operators
		bool x=true;
		bool y=false;
		Console.WriteLine(x&&y);      //returns true if both operands are true
		Console.WriteLine(x||y);       //returns true if at least one operand is true
		Console.WriteLine(!x);        //reverse the state of the operand
		
		//Assignment Operators
		Console.WriteLine(a=b);       //assigns the right operand in the left
		Console.WriteLine(a+=b);       //adds the right operand to the left and assigns result to the left
		Console.WriteLine(a-=b);       //Substracts the right operand from the left and assigns result 
		Console.WriteLine(a*=b);       //Multiplies the right operand to the left and assigns result 
		Console.WriteLine(a/=b);       //divides the left operand to the left and assigns result 
		Console.WriteLine(a%=b);       //takes the modulus using two operands and assigns the result  
		
		//Unary Operators
		
		Console.WriteLine(+a);         //indicates a positive value
		Console.WriteLine(++a);        //pre-increment
		Console.WriteLine(a++);        //post-increment
		Console.WriteLine(--a);        //pre-decrement
		Console.WriteLine(a--);        //post-decrement
		
		//Ternary operator
		
		int c=(a>b)?a:b;               //checks the condition and returns one value
		Console.WriteLine(c);
		
		//Is Operator                 //checks whether an object belongs to a specific data type
		object num=10;             
		if(num is int)
		{
			Console.WriteLine("num is an integer");
		}
	}
}

		