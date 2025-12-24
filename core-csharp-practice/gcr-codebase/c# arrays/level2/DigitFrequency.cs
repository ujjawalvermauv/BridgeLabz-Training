using System;

class DigitFrequency{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] freq = new int[10];
        for (int i = 0; i < input.Length; i++){
            int digit = int.Parse(input[i].ToString());
            freq[digit]++;
        }
        for (int i = 0; i < freq.Length; i++)
            Console.WriteLine(i + " " + freq[i]);
    }
}
