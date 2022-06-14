namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given a <b>non-empty</b> array of integers nums, every element appears <b>TWICE</b> except for one. Find that single one.<br/>
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// </summary>
public sealed class Solution136
{
	public static int SingleNumber(int[] nums)
	{
		var num = 0;
		for (var i = 0; i < nums.Length; i++)
			num ^= nums[i];

		return num;
	}
}
