namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an array nums of size n, return the <i>majority element</i>.<br/>
/// The majority element is the element that appears more than [n / 2] times. You may assume that the majority element always exists in the array.
/// </summary>
public sealed class Solution169
{
	public static int MajorityElement(int[] nums)
	{
		var result = nums[0];
		for (int i = 1, count = 1; i < nums.Length; i++)
		{
			// If the count becomes zero it means that the current element cannot be the majority
			// Therefore, assume that the next element is the majority
			if (count == 0)
				result = nums[i];

			if (nums[i] == result)
				count++;
			else
				count--;
		}

		return result;
	}
}
