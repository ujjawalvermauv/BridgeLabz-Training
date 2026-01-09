using System;

// Cardio Workout
public class CardioWorkout : FitnessTracker
{
    public CardioWorkout(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Cardio workout started");
    }

    public override void End()
    {
        Console.WriteLine("Cardio workout ended");
    }

    public override int CaloriesBurned()
    {
        return duration * 10;
    }
}

// Strength Workout
public class StrengthWorkout : FitnessTracker
{
    public StrengthWorkout(int duration) : base(duration)
    {
    }

    public override void Start()
    {
        Console.WriteLine("Strength workout started");
    }

    public override void End()
    {
        Console.WriteLine("Strength workout ended");
    }

    public override int CaloriesBurned()
    {
        return duration * 8;
    }
}
