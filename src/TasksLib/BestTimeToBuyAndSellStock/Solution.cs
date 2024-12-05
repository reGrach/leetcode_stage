namespace TasksLib.BestTimeToBuyAndSellStock
;

/// <summary>
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// 
/// You want to maximize your profit by choosing a single day to buy one stock
/// and choosing a different day in the future to sell that stock.
/// 
/// Return the maximum profit you can achieve from this transaction.
/// If you cannot achieve any profit, return 0.
/// </summary>

public class Solution
{
    public int MaxProfit_best(int[] prices)
    {
        int maxProfit = 0;
        int i = 0;
        int j = 1;
        while (j < prices.Length)
        {
            if (prices[i] >= prices[j])
            {
                i = j;
            }
            else
            {
                if (prices[j] - prices[i] > maxProfit)
                    maxProfit = prices[j] - prices[i];
            }

            j++;
        }

        return maxProfit;
    }

    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            if (minPrice > prices[i])
            {
                minPrice = prices[i];

                int currentMax = prices[i];

                for (int j = i; j < prices.Length; j++)
                {
                    if (prices[j] > currentMax)
                    {
                        currentMax = prices[j];

                        if (prices[j] - prices[i] > maxProfit)
                        {
                            maxProfit = prices[j] - prices[i];
                        }
                    }
                }
            }
        }
        return maxProfit;
    }
}
