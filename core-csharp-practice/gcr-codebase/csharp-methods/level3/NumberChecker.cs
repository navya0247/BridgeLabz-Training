using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class NumberChecker
    {
        // a. Method to count digits
        public static int CountDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        // b. Store digits in an array
        public static int[] StoreDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        // c. Check duck number 
        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    return true;   // if any digit is non-zero return true
                }
            }
            return false;
        }

        // d. Armstrong number using digits array
        public static bool IsArmstrong(int[] digits)
        {
            int sum = 0;
            int count = digits.Length;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], count);
            }
            int original = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                original = original * 10 + digits[i];
            }

            return sum == original;
        }

        // e. Largest and second largest
        public static int[] FindLargestSecondLargest(int[] digits)
        {
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] < largest)
                {
                    secondLargest = digits[i];
                }
            }

            return new int[] { largest, secondLargest };
        }

        // f. Smallest and second smallest
        public static int[] FindSmallestSecondSmallest(int[] digits)
        {
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[i];
                }
                else if (digits[i] < secondSmallest && digits[i] > smallest)
                {
                    secondSmallest = digits[i];
                }
            }

            return new int[] { smallest, secondSmallest };
        }
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] digits = StoreDigits(number);

            // show all digits of the number
            foreach (int d in digits)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();

            // total number of digits
            int digitCount = CountDigits(number);
            Console.WriteLine("Total digits: " + digitCount);

            // duck number check
            bool duck = IsDuckNumber(digits);
            Console.WriteLine("Duck number? " + (duck ? "Yes" : "No"));

            // armstrong check
            bool arm = IsArmstrong(digits);
            Console.WriteLine("Armstrong number " + (arm ? "Yes" : "No"));

            // largest and second largest digits
            int[] big = FindLargestSecondLargest(digits);
            Console.WriteLine("Biggest digit: " + big[0]);
            Console.WriteLine("Second biggest digit: " + big[1]);

            // smallest and second smallest digits
            int[] small = FindSmallestSecondSmallest(digits);
            Console.WriteLine("Smallest digit: " + small[0]);
            Console.WriteLine("Second smallest digit: " + small[1]);

        }
    }
}
