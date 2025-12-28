using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.strings
{
    internal class NullReference
    {
        //Method for Null Reference Exception
        public static void ShowNullReference()
        {
            string s1 = null;                       //take string as null

            try                //error throw
            {
                Console.WriteLine(s1.Length);
                
            }
            catch(NullReferenceException e)  //catches null reference exception
            {
                Console.WriteLine("Message " + e.Message);
            }
        }

        public static void Main(string[] args)
        {     
            //Method call
            ShowNullReference();
        }

    }
}
