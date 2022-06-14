namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.<br/>
/// You want to maximize your profit by choosing a <b>single day</b> to buy one stock and choosing a <b>different day in the future</b> to sell that stock.<br/>
/// Return the <i>maximum profit you can achieve from this transaction</i>. If you cannot achieve any profit, return 0.
/// </summary>
public sealed class Solution121
{
	public static int MaxProfit(int[] prices)
	{
		if (prices.Length == 0)
			return 0;

		int minPrice = prices[0], maxProfit = 0;
		for (var i = 1; i < prices.Length; i++)
		{
			if (prices[i] < minPrice)
				minPrice = prices[i];

			if (prices[i] - minPrice > maxProfit)
				maxProfit = prices[i] - minPrice;
		}

		return maxProfit;
	}
}
