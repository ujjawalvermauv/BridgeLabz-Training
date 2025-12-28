using System;

class TimeZoneDisplay
{
    static void Main(string[] args)
    {
        // Get current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        // Get time zone information
        TimeZoneInfo gmtZone = TimeZoneInfo.Utc;
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert UTC time to different time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

        // Display results
        Console.WriteLine("GMT Time: " + gmtTime);
        Console.WriteLine("IST Time: " + istTime);
        Console.WriteLine("PST Time: " + pstTime);
    }
}
