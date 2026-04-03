using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.FitnessTracker
{
          // User profile class 
        internal class UserProfile
        {
            // Stores user name
            public string UserName { get; set; }

            // Constructor
            public UserProfile(string name)
            {
                UserName = name;
            }

            // Method to perform a workout
            public void PerformWorkout(Workout workout)
            {
                Console.WriteLine("\nUser: " + UserName);
                workout.TrackWorkout();
                workout.ShowSummary();
            }
        }

    }





