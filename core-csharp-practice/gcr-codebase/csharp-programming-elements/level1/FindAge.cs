using System;

class FindAge
{
    static void Main(){
        string name="harry";
        int birthyear=2000;
        int currentyear=2024;

        int age=currentyear-birthyear;

        Console.WriteLine(name + "'s age in " + currentyear + " is " + age);

    }
}