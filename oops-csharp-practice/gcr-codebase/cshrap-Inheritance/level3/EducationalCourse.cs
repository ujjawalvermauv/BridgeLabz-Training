using System;

class Course
{
    public string CourseName;
    public int CourseDuration; // in hours

    public Course(string courseName, int courseDuration)
    {
        CourseName = courseName;
        CourseDuration = courseDuration;
    }

    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Course Duration: " + CourseDuration + " hours");
    }
}

class OnlineCourse : Course
{
    public string platform;
    public bool isRecorded;

    public OnlineCourse(string courseName, int courseDuration, string platform, bool isRecorded) : base(courseName, courseDuration)   //  constructor chaining
    {
        this.platform = platform;
        this.isRecorded = isRecorded;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo(); // parent method call
        Console.WriteLine("Platform: " + platform);
        Console.WriteLine("Is Recorded: " + isRecorded);
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public int fees;
    public double discount;

    public PaidOnlineCourse(string courseName, int courseDuration, string platform, bool isRecorded, int fees, double discount): base(courseName, courseDuration, platform, isRecorded)
    {
        this.fees = fees;
        this.discount = discount;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo(); //calls OnlineCourse → Course
        Console.WriteLine("Fees: " + fees);
        Console.WriteLine("Discount: " + discount + "%");
    }
}

class Program
{
    static void Main()
    {
        PaidOnlineCourse course =
            new PaidOnlineCourse("C# Full Stack", 120, "Udemy", true, 5000, 20);

        course.DisplayCourseInfo();
    }
}
