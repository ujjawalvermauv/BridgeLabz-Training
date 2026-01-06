using System;
//monitor step taking evry day
//calories per day
//how much km travlled
//bmi 
class fitnessTrackeruser
{
    public int weight; //fields
    public int height;
    public int steps;

    public fitnessTrackeruser(int weight, int height) //constructor
    {
        this.height = height;
        this.weight = weight;

    }
    public void dailySteps(int steps) //method to daily steps
    {
        this.steps += steps;
        Console.WriteLine("Total Steps today: " + steps);
    }
    public void caloriesBurned() //method to calculate calories burned
    {
        int calories = steps / 15;
        Console.WriteLine("Total Calories Burned: " + calories);
    }
    public void calculateBMI() //method for calculating bmi
    {
        double heightInMeters = height / 100;
        double bmi = weight / (heightInMeters);
        Console.WriteLine("your bmi is: " + bmi);
    }

    public static void Main()
    {
        fitnessTrackeruser user = new fitnessTrackeruser(70, 175);
        user.dailySteps(3000);
        user.dailySteps(4500);
        user.calculateBMI();
        user.caloriesBurned();
    }











}