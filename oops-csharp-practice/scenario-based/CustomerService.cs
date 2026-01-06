using System;
class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime TimeStamp;

    // Constructor to initialize call log details
    public CallLog(string phoneNumber, string message, DateTime timeStamp)
    {
        PhoneNumber = phoneNumber;
        Message = message;
        TimeStamp = timeStamp;
    }

    // Method to display call log details
    public void Display()
    {
        Console.WriteLine("Phone Number : " + PhoneNumber);
        Console.WriteLine("Message      : " + Message);
        Console.WriteLine("Time         : " + TimeStamp);
        Console.WriteLine("");
    }
}

// Main class to manage call logs
class CallLogManager
{
    // Array to store call logs
    static CallLog[] callLogs = new CallLog[10];
    static int count = 0;

    static void Main()
    {
        // Adding sample call logs
        AddCallLog("9876543210", "Network issue reported", DateTime.Now.AddHours(-3));
        AddCallLog("9123456780", "Billing related query", DateTime.Now.AddHours(-2));
        AddCallLog("9988776655", "Internet not working", DateTime.Now.AddHours(-1));
        Console.WriteLine("Search Result (Keyword: 'Internet')");
        SearchByKeyword("Internet");
        Console.WriteLine("\nFilter Result (Last 2 Hours)");
        FilterByTime(DateTime.Now.AddHours(-2), DateTime.Now);
    }
    // Method to add a call log to array
    static void AddCallLog(string phone, string message, DateTime time)
    {
        if (count < callLogs.Length)
        {
            callLogs[count] = new CallLog(phone, message, time);
            count++;
        }
        else
        {
            Console.WriteLine("Call log storage is full.");
        }
    }
    // Method to search logs by keyword in message
    static void SearchByKeyword(string keyword)
    {
        for (int i = 0; i < count; i++)
        {
            if (callLogs[i].Message.Contains(keyword))
            {
                callLogs[i].Display();
            }
        }
    }
    // Method to filter logs by time range
    static void FilterByTime(DateTime startTime, DateTime endTime)
    {
        for (int i = 0; i < count; i++)
        {
            if (callLogs[i].TimeStamp >= startTime &&
                callLogs[i].TimeStamp <= endTime)
            {
                callLogs[i].Display();
            }
        }
    }
}
