class CelsiusToFahrenheit{
public static void Main(String[] args){
	double celsius=double.Parse(Console.ReadLine()); 	//take temperature in celsius
	double Fahrenheit=(celsius*9/5)+32;            //convert celsius into Fahrenheit
	Console.WriteLine("Temperature in fahrenheit is:" + Fahrenheit);
}
}