using System;
class PenGet{
	public static void Main(String[]args){
		int pen=14;                                 //total pens
		int student=3;                              //no of students
		int quantity=pen/student;                   //each student will get
		int remain=pen%student;                     //remaining pens
		Console.WriteLine("The Pen Per Student is "+quantity+" and the remaining pen not distributed is "+remain);
	}
}
		