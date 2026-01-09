using System;

class FitnessTrackerMain
{
    static void Main(string[] args)
    {
        UserProfile user = new UserProfile("Ujjawal", 22, 70, 175);
        user.DisplayUser();
        Console.WriteLine();
        Console.WriteLine("Select Workout Type");
        Console.WriteLine("1. Cardio Workout");
        Console.WriteLine("2. Strength Workout");
        int choice = int.Parse(Console.ReadLine());
        ITrackable workout = FitnessTrackerMenu.GetWorkout(choice); // Factory Method Pattern
        if (workout != null)
        {
            user.PerformWorkout(workout);
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}
