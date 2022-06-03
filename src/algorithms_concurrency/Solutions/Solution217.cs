namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer array nums, return true if any value appears <b>at least twice</b> in the array, and return false if every element is distinct.
/// </summary>
public sealed class Solution217
{
	public static bool ContainsDuplicate(int[] nums)
	{
		var set = new HashSet<int>();
		for (var i = 0; i < nums.Length; i++)
		{
			if (!set.Add(nums[i]))
				return true;
		}

		return false;
	}
}
