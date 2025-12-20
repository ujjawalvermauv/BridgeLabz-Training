using System;

class FeeDiscount
{
    static void Main()
    {
        double fee = 125000;
        double discountPercent = 10;

        double discountAmount = (fee * discountPercent) / 100;
        double finalFee = fee - discountAmount;

        Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);
    }
}
