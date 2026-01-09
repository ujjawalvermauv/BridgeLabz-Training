using System;

public class UserProfile
{
    private string username; // 
    private int age;
    private int weight;
    private int height;

    public UserProfile(string username, int age, int weight, int height)
    {
        this.username = username;
        this.age = age;
        this.weight = weight;
        this.height = height;
    }

    public void DisplayUser()
    {
        Console.WriteLine("User Name: " + username);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight + " kg");
        Console.WriteLine("Height: " + height + " cm");
    }

    // Polymorphism used here
    public void PerformWorkout(ITrackable workout)
    {
        workout.StartWorkout();
        Console.WriteLine("Calories Burned: " + workout.GetCaloriesBurned());
        workout.EndWorkout();
    }
}
