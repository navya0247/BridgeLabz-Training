using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraString
{
    internal class Replace
    {  
        public static void Main(string[] args)
        {
            //take input from user
            string sentence = Console.ReadLine();
            string oldWord = Console.ReadLine();
            string newWord = Console.ReadLine();

            string result = sentence.Replace(oldWord, newWord);

                // print result
                Console.WriteLine("Modified Sentence: " + result);
            }
        }
    }

