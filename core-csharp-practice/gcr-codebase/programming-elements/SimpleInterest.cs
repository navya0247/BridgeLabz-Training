class SimpleInterest{
	public static void Main(String[]args){
		int principal=40;                                     //take principal as input
		int rate=10;                                          //take rate as input
		int time=4;                                           //take time as input
		int si=(principal*rate*time)/100;                      //calculate the simple interest
		Console.WriteLine("Simple Interest is:"+ si);
	}
}