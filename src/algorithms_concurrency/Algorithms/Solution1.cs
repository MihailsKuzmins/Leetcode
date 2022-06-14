namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.<br/>
/// You may assume that each input would have <b>exactly one solution</b>, and you may not use the same element twice.<br/>
/// You can return the answer in any order.
/// </summary>
public sealed class Solution1
{
	public static int[] TwoSum(int[] nums, int target)
	{
		var dictionary = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			var result = target - nums[i];
			if (dictionary.TryGetValue(result, out var value))
				return new[] { value, i };

			dictionary.Add(nums[i], i);
		}

		throw new Exception();
	}
}
