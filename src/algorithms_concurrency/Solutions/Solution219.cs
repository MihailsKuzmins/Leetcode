namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer array nums and an integer k, return true if there are two <b>distinct indices</b> i and j in the array such that nums[i] == nums[j] and abs(i - j) &lt;= k.
/// </summary>
public sealed class Solution219
{
	public static bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var dic = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			if (dic.TryGetValue(nums[i], out var index) && i - index <= k)
				return true;

			dic[nums[i]] = i;
		}

		return false;
	}
}
