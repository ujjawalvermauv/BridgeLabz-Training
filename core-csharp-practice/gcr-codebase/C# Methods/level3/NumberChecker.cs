using System;

class NumberChecker
{
    // a. Find the count of digits in the number
    public static int CountDigits(int number)
    {
        if (number == 0) return 1;
        int count = 0;
        int temp = Math.Abs(number);
        while (temp > 0)
        {
            temp /= 10;
            count++;
        }
        return count;
    }

    // b. Store digits in an array
    public static int[] GetDigitsArray(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        int temp = Math.Abs(number);
        
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    // c. Duck Number check (has at least one non-zero digit)
    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] != 0) return true;
        }
        return false;
    }

    // d. Armstrong Number check
    public static bool IsArmstrong(int number)
    {
        int[] digits = GetDigitsArray(number);
        int n = digits.Length;
        double sum = 0;
        
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Math.Pow(digits[i], n);
        }
        return (int)sum == number;
    }

    // e. Find Largest and Second Largest
    public static void DisplayLargestAndSecond(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }
        Console.WriteLine("Largest: " + largest + ", Second Largest: " + secondLargest);
    }

    // f. Find Smallest and Second Smallest
    public static void DisplaySmallestAndSecond(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest)
            {
                secondSmallest = digits[i];
            }
        }
        Console.WriteLine("Smallest: " + smallest + ", Second Smallest: " + secondSmallest);
    }

    static void Main()
    {
        Console.Write("Enter a number to check: ");
        int input = int.Parse(Console.ReadLine());

        int[] digits = GetDigitsArray(input);

        Console.WriteLine("Digit Count: " + CountDigits(input));
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrong(input));
        
        DisplayLargestAndSecond(digits);
        DisplaySmallestAndSecond(digits);
    }
}