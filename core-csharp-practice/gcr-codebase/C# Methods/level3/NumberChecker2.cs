using System;

class NumberChecker2
{
    // a. Method to find count and store digits in an array
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

    // b. Method to find the sum of digits
    public static int FindSumOfDigits(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        return sum;
    }

    // c. Method to find the sum of the squares of digits
    public static double FindSumOfSquares(int[] digits)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sumOfSquares += Math.Pow(digits[i], 2);
        }
        return sumOfSquares;
    }

    // d. Method to check if a number is a Harshad number
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = FindSumOfDigits(digits);
        if (sum == 0) return false;
        return (number % sum == 0);
    }

    // e. Method to find frequency of each digit using a 2D array
    public static int[,] FindDigitFrequency(int[] digits)
    {
        // 10 rows for digits 0-9, 2 columns for [Digit, Count]
        int[,] frequencyMap = new int[10, 2];
        
        // Initialize the first column with digits 0-9
        for (int i = 0; i < 10; i++)
        {
            frequencyMap[i, 0] = i;
            frequencyMap[i, 1] = 0;
        }

        // Count frequencies
        for (int i = 0; i < digits.Length; i++)
        {
            int digitValue = digits[i];
            frequencyMap[digitValue, 1]++;
        }
        return frequencyMap;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int[] digits = GetDigitsArray(inputNumber);

        Console.WriteLine("Sum of Digits: " + FindSumOfDigits(digits));
        Console.WriteLine("Sum of Squares of Digits: " + FindSumOfSquares(digits));
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(inputNumber, digits));

        int[,] freq = FindDigitFrequency(digits);
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i, 1] > 0)
            {
                Console.WriteLine("Digit " + freq[i, 0] + " appears " + freq[i, 1] + " times");
            }
        }
    }
}