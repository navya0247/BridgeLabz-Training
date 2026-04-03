using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections.annotations
{
    internal class SuppressWarningsUnchecked
    {
           public static void Main(string[] args)
            {

                ArrayList list = new ArrayList();
                list.Add(10);
                list.Add("Hello");

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }

