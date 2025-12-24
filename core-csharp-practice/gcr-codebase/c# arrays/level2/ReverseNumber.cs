using System;

class ReverseNumber
{
    static void Main(string[] args){
        string input = Console.ReadLine();
        int count = input.Length;
        int[] digits = new int[count];
        for (int i = 0; i < count; i++){
             digits[i] = int.Parse(input[i].ToString());

        }
        for (int i = count - 1; i >= 0; i--)
            Console.Write(digits[i]);
    }
}
