using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.FitnessTracker
{
        // Abstract class for common workout details
        internal abstract class Workout : ITrackable
        {
            // Name of the workout
            public string WorkoutName { get; set; }

            // Duration of workout in minutes
            public int Duration { get; set; }

            // Constructor to initialize workout data
            public Workout(string name, int duration)
            {
                WorkoutName = name;
                Duration = duration;
            }

            // Abstract methods to be implemented by child classes
            public abstract void TrackWorkout();
            public abstract void ShowSummary();
        }
    }


