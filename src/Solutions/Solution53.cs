namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.<br/>
/// A <b>subarray</b> is a <b>contiguous</b> part of an array.
/// </summary>
public sealed class Solution53
{
	public static int MaxSubArray(int[] nums)
	{
		if (nums.Length == 0)
			return 0;

		var max = nums[0];
		for (int i = 1, sum = max; i < nums.Length; i++)
		{
			// Trick: if the sum has become negative there is no way that it can become the max sum
			// E.g. If we hit negative and the next number is greater, the next number itself is greater than the sum
			// Therefore, we need to discard all the input as soon as we hit negative

			// If the sum becomes negative we don't need calculate all the previous elements
			// So we clear the accumulated sum and start from the current element
			if (sum < 0)
				sum = 0;

			sum += nums[i];

			if (sum > max)
				max = sum;
		}

		return max;
	}
}
