namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// You are climbing a staircase. It takes n steps to reach the top.<br/>
/// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
/// </summary>
public sealed class Solution70
{
	public static int ClimbStairs(int n)
	{
		const int forOne = 1, forTwo = 2;

		switch (n)
		{
			case <= 0: return 0;
			case 1: return forOne;
			case 2: return forTwo;
		}

		// Possible ways to climb:
		// 1. (n - 1) + 1 step
		// 2. (n - 2) + 2 steps
		// So the number of steps is: (n - 1) + (n - 2)
		int beforePrev = forOne, before = forTwo;
		for (var i = 3; i < n; i++)
		{
			before += beforePrev;
			beforePrev = before - beforePrev;
		}

		return beforePrev + before;
	}
}
