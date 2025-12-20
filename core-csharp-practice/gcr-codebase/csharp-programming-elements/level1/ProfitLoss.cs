using System;

class ProfitLoss{
    static void Main(){
        double sellingPrice=191;
        double costPrice=129;

        double profit=sellingPrice-costPrice;
        double profitPer= profit/costPrice*100;
        Console.WriteLine("The Cost Price is INR"+ costPrice + "and Selling Price is INR" + sellingPrice );
        Console.WriteLine("The Profit is INR"+ profit +" the Profit Percentage is" + profitPer);
    }
}