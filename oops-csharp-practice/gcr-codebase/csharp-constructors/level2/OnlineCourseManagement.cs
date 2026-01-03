using System;
using System.Runtime.CompilerServices;

public class OnlineCourceManagement
{
    public string courseName; // Instance Variable
    public int courseDuration; // Instance Variable
    public int courseFee; // Instance Variable
    public static String instituteName = "Vits Pilani";// Class Variable
    public OnlineCourceManagement(string courseName, int courseDuration, int courseFee)
    {
        this.courseName = courseName; // Using 'this' keyword to resolve ambiguity
        this.courseDuration = courseDuration;
        this.courseFee = courseFee;
    }
    public void DisplayCourseDetails()
    {
        System.Console.WriteLine("Course Name: " + courseName);
        System.Console.WriteLine("Course Duration: " + courseDuration + " months");
        System.Console.WriteLine("Course Fee: " + courseFee + " INR");
        System.Console.WriteLine("Institute Name: " + instituteName);
        System.Console.WriteLine();
    }
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
    public static void Main()
    {
        OnlineCourceManagement cource1 = new OnlineCourceManagement("CSharp Programming", 6, 30000);
        OnlineCourceManagement cource2 = new OnlineCourceManagement("Java Programming", 8, 35000);
        // using static method to update institute name
        OnlineCourceManagement.UpdateInstituteName("BridgeLabz");
        cource1.DisplayCourseDetails();
        cource2.DisplayCourseDetails();

    }








}