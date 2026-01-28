using System;

class HappyNo
{
   public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int result = num;

        while (result != 1 && result != 4)   
        {
            result = SumOfSquares(result);
        }

        if (result == 1)
            Console.WriteLine(num + " is a Happy Number");
        else
            Console.WriteLine(num + " is NOT a Happy Number");
    }

    static int SumOfSquares(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum = sum + digit * digit;
            n = n / 10;
        }

        return sum;
    }
}
