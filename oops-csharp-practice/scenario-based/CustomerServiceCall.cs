using System;
using System.Collections.Generic;
using System.Text;


namespace BridgeLabzTraining.oops.scenarioBased
{
    
    class CallLog
    {
        public string PhoneNumber;
        public string Message;
        public DateTime TimeStamp;

        public CallLog(string phoneNumber, string message, DateTime timeStamp)
        {
            PhoneNumber = phoneNumber;
            Message = message;
            TimeStamp = timeStamp;
        }

        public void Display()
        {
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("Message      : " + Message);
            Console.WriteLine("Time         : " + TimeStamp);
        }
    }

    
    class CallLogManager
    {
        private CallLog[] logs;
        private int logCount = 0;

        public CallLogManager(int size)
        {
            logs = new CallLog[size];
        }

        // add a call log
        public void AddCallLog(CallLog log)
        {
            if (logCount < logs.Length)
            {
                logs[logCount] = log;
                logCount++;
            }
            else
            {
                Console.WriteLine("Invalid call log");
            }
        }

        // search logs by keyword in message
        public void SearchByKeyword(string keyword)
        {
            Console.WriteLine("\nSearch results for keyword: " + keyword);

            for (int i = 0; i < logCount; i++)
            {
                if (logs[i].Message.Contains(keyword))
                {
                    logs[i].Display();
                    Console.WriteLine();
                }
            }
        }

        // filter logs by time range
        public void FilterByTime(DateTime fromTime, DateTime toTime)
        {
            Console.WriteLine("\nLogs between " + fromTime + " and " + toTime);

            for (int i = 0; i < logCount; i++)
            {
                if (logs[i].TimeStamp >= fromTime && logs[i].TimeStamp <= toTime)
                {
                    logs[i].Display();
                    Console.WriteLine();
                }
            }
        }
    }

    // main class
    internal class CustomerServiceCall
    {
        public static void Main(string[] args)
        {
            CallLogManager manager = new CallLogManager(5);

            // adding call logs
            manager.AddCallLog(new CallLog(
                "9012345678",
                "Internet speed is very slow",
                DateTime.Now.AddHours(-4)));

            manager.AddCallLog(new CallLog(
                "8899776655",
                "Unable to make outgoing calls",
                DateTime.Now.AddHours(-2)));

            manager.AddCallLog(new CallLog(
                "7766554433",
                "Recharge not reflected",
                DateTime.Now.AddMinutes(-30)));

            // search logs using keyword
            manager.SearchByKeyword("call");

            // filter logs by time range
            DateTime from = DateTime.Now.AddHours(-5);
            DateTime to = DateTime.Now;

            manager.FilterByTime(from, to);
        }
    }
}
