using System;

class NumberCheckerExtended
{
    public static int[] GetDigitsArray(int number)
    {
        int temp = Math.Abs(number);
        string numStr = temp.ToString();
        int[] digits = new int[numStr.Length];
        for (int i = numStr.Length - 1; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    // b. Method to reverse the digits array
    public static int[] ReverseArray(int[] original)
    {
        int[] reversed = new int[original.Length];
        int j = 0;
        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed[j] = original[i];
            j++;
        }
        return reversed;
    }

    // c. Method to compare two arrays
    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

    // d. Method to check if Palindrome
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    // e. Method to check if Duck Number (contains a non-zero digit)
    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] != 0) return true;
        }
        return false;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        int[] digits = GetDigitsArray(input);

        Console.WriteLine("Is Palindrome: " + IsPalindrome(digits));
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));

        int[] reversed = ReverseArray(digits);
        Console.Write("Reversed Digits: ");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i]);
        }
        Console.WriteLine();
    }
}