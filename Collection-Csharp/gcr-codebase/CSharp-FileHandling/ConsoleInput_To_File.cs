using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        try
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter sw = new StreamWriter("userData.txt"))
            {
                Console.Write("Name: ");
                string name = sr.ReadLine();

                Console.Write("Age: ");
                string age = sr.ReadLine();

                Console.Write("Favorite Language: ");
                string lang = sr.ReadLine();

                sw.WriteLine($"Name: {name}");
                sw.WriteLine($"Age: {age}");
                sw.WriteLine($"Language: {lang}");
            }

            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
