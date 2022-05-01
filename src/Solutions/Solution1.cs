namespace MyNihongo.Leetcode.Solutions;

public sealed class Solution1
{
	public int[] TwoSum(int[] nums, int target)
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
