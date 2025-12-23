using System;

class SmallestNumber{
    static void Main(){
        int num1=int.Parse(Console.ReadLine());
        int num2=int .Parse(Console.ReadLine());
        int num3=int.Parse(Console.ReadLine());
        bool result=(num1<num2&& num1<num3);
        Console.WriteLine(" Is the first number the smallest?" + result);
    }

}