using System;

class DivByFive{
    static void Main(){
        int num =int.Parse(Console.ReadLine());
        bool isdivisible=num % 5 ==0;
        Console.WriteLine("Is the number" + num + "divisible by 5?" + isdivisible);
    }
}