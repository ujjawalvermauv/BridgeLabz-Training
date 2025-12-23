using System;

class MultiplesBelowHundred
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 100; i >= 1; i--){
            if (i % number == 0){
                Console.WriteLine(i);
            }
        }
    }
}
