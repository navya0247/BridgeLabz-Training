using System;
class DataTypes{
	static void Main(String[] args){
		int a=20;  		//stores the whole numbers
		Console.WriteLine(a);
		
		short b=150;                // stores small whole numbers
		Console.WriteLine(b);
		
		byte c=20;                 // stores very small whole numbers
		Console.WriteLine(c);
		
		long d=9876543210L;         //stores the very large whole numbers
		Console.WriteLine(d);
		
		float e=85.5f;             //stores the small decimal values
		Console.WriteLine(e);
		
		double f=45000.75;          //stores the default decimal values
		Console.WriteLine(f);
		
		char g='A';                  //stores the character
		Console.WriteLine(g);
		
		bool h=true;                 //stores true or false
		Console.WriteLine(h);
		
	//Type casting
	
	//Implicit type casting
	
	byte bb=10;
	short s=bb;          //byte to short
	Console.WriteLine(s);
	
	int i=s;            //short to int
	Console.WriteLine(i);
	
	long l=i;           //int to long
	Console.WriteLine(l);
	
	float ff=l;           //long to float
	Console.WriteLine(ff);
	
	double dd=ff;         //float to double
	Console.WriteLine(dd);
	
	//Explicit type casting
	
	double d1=22.8;
	float f1=(float)d1;       //double to float
	Console.WriteLine(f1);
	long l1=(long)f1;         //float to long
	Console.WriteLine(l1);
	int i1=(int)l1;           // long to int
	Console.WriteLine(i1);
	short s1=(short)i1;       //int to short
	Console.WriteLine(s1);
	}
}