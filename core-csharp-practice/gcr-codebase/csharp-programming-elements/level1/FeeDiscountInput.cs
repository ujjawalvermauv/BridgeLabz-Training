using System;

class FeeDiscountInput
{
    static void Main()
    {
        double fee, discountPercent;

        Console.Write("Enter fee: ");
        fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        discountPercent = Convert.ToDouble(Console.ReadLine());

        double discount = (fee * discountPercent) / 100;
        double finalFee = fee - discount;

        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
