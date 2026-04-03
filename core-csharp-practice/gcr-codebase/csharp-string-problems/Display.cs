using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class Display
    {
        // method to find length 
        public static int MyLength(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }

        // method to split words 
        public static string[] MakeWord(string s)
        {
            List<string> words = new List<string>();
            string currentWord = "";

            foreach (char c in s)
            {
                if (c != ' ')
                {
                    currentWord += c;     
                }
                else
                {
                    if (currentWord != "") 
                    {
                        words.Add(currentWord);
                        currentWord = ""; 
                    }
                }
            }

            // add last word if exists
            if (currentWord != "")
            {
                words.Add(currentWord);
            }

            return words.ToArray();
        }

        // method to create 2D array
        public static string[,] WordAndLength(string s)
        {
            string[] words = MakeWord(s);
            string[,] result = new string[words.Length, 2];

            for (int i = 0; i < words.Length; i++)
            {
                result[i, 0] = words[i];
                result[i, 1] = MyLength(words[i]).ToString();
            }

            return result;
        }

        public static void Main(string[] args)
        {
            //input from user
            string input = Console.ReadLine();

            string[,] output = WordAndLength(input);

            for (int i = 0; i < output.GetLength(0); i++)
            {
                Console.WriteLine("Word " + output[i, 0] + " Length " + output[i, 1]);
            }
        }
    }
}
