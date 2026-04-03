using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.extraBuiltIn.level1
{
    internal class TimeZone
    {
        public static void Main(string[] args)
        {
            // get current UTC time 
            DateTimeOffset currentTime = DateTimeOffset.UtcNow;

            Console.WriteLine("Current Time in Different Time Zones ");

            // GMT
            Console.WriteLine("GMT " + currentTime);

            // IST (Indian Standard Time)
            TimeSpan istOffset = TimeSpan.FromHours(5.5);
            Console.WriteLine("IST " + currentTime.ToOffset(istOffset));

            // PST (Pacific Standard Time) 
            TimeSpan pstOffset = TimeSpan.FromHours(-8);
            Console.WriteLine("PST " + currentTime.ToOffset(pstOffset));
        }
    }

}

