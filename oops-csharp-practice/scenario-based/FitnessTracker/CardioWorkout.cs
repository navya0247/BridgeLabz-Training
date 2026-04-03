using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.FitnessTracker
{
        // Cardio workout 
        internal class CardioWorkout : Workout
        {
            // Distance covered in km
            public int Distance { get; set; }

            // Constructor
            public CardioWorkout(string name, int duration, int distance)
                : base(name, duration)
            {
                Distance = distance;
            }

            // Track cardio workout
            public override void TrackWorkout()
            {
                Console.WriteLine("Tracking Cardio Workout");
                Console.WriteLine("Workout Name: " + WorkoutName);
                Console.WriteLine("Duration: " + Duration + " minutes");
            }

            // Show cardio summary
            public override void ShowSummary()
            {
                Console.WriteLine("Distance Covered: " + Distance + " km");
            }
        }

    }

