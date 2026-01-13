using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.digitalBookshelfApp
{
    internal class BookMain
    {
        public static void Main(string[] args)
        {
            BookMenu utility = new BookMenu();

            utility.ShowMenu();
        }
    }
}
