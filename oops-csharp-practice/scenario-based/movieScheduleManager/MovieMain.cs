using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.movieScheduleManager
{
    internal class MovieMain
    {
        public static void Main(string[] args)
        {
            MovieUtility utility = new MovieUtility();

            MovieMenu.ShowMenu(utility);
        }
    }
}

              




