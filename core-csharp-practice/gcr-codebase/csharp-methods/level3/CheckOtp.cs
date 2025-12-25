using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.methods.level3
{
    internal class CheckOtp
    {
        // a) Method to generate a 6-digit OTP
        public static int GenerateOTP()
        {
            Random rand = new Random();
            return rand.Next(100000, 1000000); // generates 100000 to 999999
        }

        // c) Method to check uniqueness of OTPs
        public static bool AreOTPsUnique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                        return false;  
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            // b) Array to store 10 OTPs
            int[] otpArray = new int[10];

            // Generate OTPs 
            for (int i = 0; i < otpArray.Length; i++)
            {
                otpArray[i] = GenerateOTP();
            }

            // Print OTPs
            foreach (int otp in otpArray)
            {
                Console.WriteLine(otp);
            }

            // Check uniqueness
            bool unique = AreOTPsUnique(otpArray);
           Console.WriteLine("Are all OTPs unique? " + (unique ? "Yes" : "No"));
        }
    }
}
