using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.FitnessTracker
{
        // Strength workout 
        internal class StrengthWorkout : Workout
        {
            // Number of repetitions
            public int Reps { get; set; }

            // Constructor
            public StrengthWorkout(string name, int duration, int reps)
                : base(name, duration)
            {
                Reps = reps;
            }

            // Track strength workout
            public override void TrackWorkout()
            {
                Console.WriteLine("Tracking Strength Workout");
                Console.WriteLine("Workout Name: " + WorkoutName);
                Console.WriteLine("Duration: " + Duration + " minutes");
            }

            // Show strength summary
            public override void ShowSummary()
            {
                Console.WriteLine("Total Reps: " + Reps);
            }
        }

    }

