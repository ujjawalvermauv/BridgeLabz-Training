using System;
using System.Collections.Generic;

class StockSpan
{
    static void CalculateSpan(int[] price)
    {
        Stack<int> stack = new Stack<int>();
        int[] span = new int[price.Length];

        for (int i = 0; i < price.Length; i++)
        {
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
                stack.Pop();

            span[i] = (stack.Count == 0) ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }

        for (int i = 0; i < span.Length; i++)
            Console.Write(span[i] + " ");
    }

    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        CalculateSpan(prices);
    }
}
