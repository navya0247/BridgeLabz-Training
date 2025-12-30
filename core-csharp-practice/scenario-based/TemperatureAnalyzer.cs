using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenarioBased
{
    internal class TemperatureAnalyzer
    {
       
       public static void Main(string[] args)
        {
            float[,] temperature = new float[7, 24];   // store hourly temperature for 7 days
            float[] studentScores = null;
            Random r = new Random();

            while (true)
            {
                Console.WriteLine("1. Temperature Analyzer");
                Console.WriteLine("2. Student Score Manager");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // generate random temperature values for a week
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 0; j < 24; j++)
                            {
                                temperature[i, j] = (float)(r.NextDouble() * 40);
                            }
                        }

                        float[] avgTemp = GetAveragePerDay(temperature);
                        int hotDay = GetHottestDay(temperature);
                        int coldDay = GetColdestDay(temperature);

                        Console.WriteLine("\nAverage temperature of each day:");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine("Day " + (i + 1) + ": " + avgTemp[i].ToString("0.00") + " degree Celsius");
                        }

                        Console.WriteLine("Hottest day number is: " + (hotDay + 1));
                        Console.WriteLine("Coldest day number is: " + (coldDay + 1));
                        break;


                    case "2":
                        studentScores = EnterScores();
                        if (studentScores == null)
                        {
                            break;
                        }

                        float avg = Average(studentScores);
                        Console.WriteLine("\nStudent Score Report:");
                        Console.WriteLine("Average score: " + avg.ToString("0.00"));
                        Console.WriteLine("Highest score: " + Highest(studentScores));
                        Console.WriteLine("Lowest score: " + Lowest(studentScores));

                        Console.WriteLine("Scores above average:");
                        for (int i = 0; i < studentScores.Length; i++)
                        {
                            if (studentScores[i] > avg)
                            {
                                Console.WriteLine(studentScores[i]);
                            }
                        }
                        break;


                    case "3":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        // method to find average temperature per day
        public static float[] GetAveragePerDay(float[,] temps)
        {
            float[] avg = new float[7];
            for (int day = 0; day < 7; day++)
            {
                float sum = 0;
                for (int hour = 0; hour < 24; hour++)
                {
                    sum += temps[day, hour];
                }
                avg[day] = sum / 24;
            }
            return avg;
        }

        // method to get hottest day based on average temperature
        public static int GetHottestDay(float[,] temps)
        {
            float[] avg = GetAveragePerDay(temps);
            int index = 0;
            for (int i = 1; i < 7; i++)
            {
                if (avg[i] > avg[index])
                {
                    index = i;
                }
            }
            return index;
        }

        // method to get coldest day based on average temperature
        public static int GetColdestDay(float[,] temps)
        {
            float[] avg = GetAveragePerDay(temps);
            int index = 0;
            for (int i = 1; i < 7; i++)
            {
                if (avg[i] < avg[index])
                {
                    index = i;
                }
            }
            return index;
        }

        // method to enter student scores and check if valid
        public static float[] EnterScores()
        {
            Console.Write("\nEnter number of students: ");
            int n;

            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid number of students!");
                return null;
            }

            float[] scores = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter score of student " + (i + 1) + ": ");
                float s;
                if (!float.TryParse(Console.ReadLine(), out s) || s < 0)
                {
                    Console.WriteLine("Invalid score. Please enter again.");
                    i--;
                    continue;
                }
                scores[i] = s;
            }
            return scores;
        }

        // calculate average score
        public static float Average(float[] arr)
        {
            float sum = 0;
            foreach (float s in arr)
            {
                sum += s;
            }
            return sum / arr.Length;
        }

        // find highest score
        public static float Highest(float[] arr)
        {
            float max = arr[0];
            foreach (float s in arr)
            {
                if (s > max)
                {
                    max = s;
                }
            }
            return max;
        }

        // find lowest score
        public static float Lowest(float[] arr)
        {
            float min = arr[0];
            foreach (float s in arr)
            {
                if (s < min)
                {
                    min = s;
                }
            }
            return min;
        }
    }

}

