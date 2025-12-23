using System;

class SmallestNumber{
    static void Main(){
        // taking input for all three numbers
        int num1=int.Parse(Console.ReadLine());
        int num2=int .Parse(Console.ReadLine());
        int num3=int.Parse(Console.ReadLine());
        // checking if num1 is the smallest one or not 
        bool result=(num1<num2&& num1<num3);
        // output according to the result of bool 
        Console.WriteLine(" Is the first number the smallest?" + result);
    }

}