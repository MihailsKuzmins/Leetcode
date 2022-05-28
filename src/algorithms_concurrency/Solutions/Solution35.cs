namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.<br/>
/// You must write an algorithm with O(log n) runtime complexity.<br/>
/// <b>Constraints:</b><br/>
/// - nums contains <b>distinct</b> values sorted in ascending order.
/// </summary>
public sealed class Solution35
{
	public static int SearchInsert(int[] nums, int target)
	{
		if (nums.Length == 0 || target <= nums[0])
			return 0;
		if (target > nums[^1])
			return nums.Length;

		int start = 0, end = nums.Length - 1, position = end / 2;
		while (start <= end)
		{
			if (nums[position] > target)
				end = position - 1;
			else if (nums[position] < target)
				start = position + 1;
			else
				return position;

			position = (start + end) / 2;
		}

		return position + 1;
	}
}
