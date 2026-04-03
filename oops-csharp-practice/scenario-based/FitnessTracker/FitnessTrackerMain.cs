using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.FitnessTracker
{
    internal class FitnessTrackerMain
    {
        public static void Main(string[] args)
        {
            // Take user name
            Console.Write("Enter user name: ");
            string userName = Console.ReadLine();

            UserProfile user = new UserProfile(userName);

            // Choose workout type
            Console.WriteLine("Choose Workout Type");
            Console.WriteLine("1. Cardio Workout");
            Console.WriteLine("2. Strength Workout");
            int choice = int.Parse(Console.ReadLine());

            // Common inputs
            Console.Write("Enter workout name: ");
            string workoutName = Console.ReadLine();

            Console.Write("Enter duration (minutes): ");
            int duration = int.Parse(Console.ReadLine());

            // Cardio workout
            if (choice == 1)
            {
                Console.Write("Enter distance (km): ");
                int distance = int.Parse(Console.ReadLine());

                Workout cardio = new CardioWorkout(workoutName, duration, distance);
                user.PerformWorkout(cardio);
            }
            // Strength workout
            else if (choice == 2)
            {
                Console.Write("Enter number of reps: ");
                int reps = int.Parse(Console.ReadLine());

                Workout strength = new StrengthWorkout(workoutName, duration, reps);
                user.PerformWorkout(strength);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

}

