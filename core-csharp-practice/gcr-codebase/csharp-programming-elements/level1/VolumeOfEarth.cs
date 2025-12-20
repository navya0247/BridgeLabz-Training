using System;
class VolumeOfEarth{
	public static void Main(String[]args){
		int radius=6378;                                           //take radius of earth
		double volume=(4/3)*3.14*radius*radius*radius;             // calculate volume in km
		double volumeMile=volume*1.6;                            //calculate volume in miles
		Console.WriteLine("The volume of earth in cubic kilometers is "+volume+" and cubic miles is "+volumeMile);
	}
}
