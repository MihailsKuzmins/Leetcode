namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.<br/>
/// Return <b>any array</b> that satisfies this condition.
/// </summary>
public sealed class Solution905
{
	public static int[] SortArrayByParity(int[] nums)
	{
		if (nums.Length == 1)
			return nums;

		for (int i = 0, unevenIndex = nums.Length - 1; i < unevenIndex; i++)
		{
			if (nums[i] % 2 == 0)
				continue;

			while (nums[unevenIndex] % 2 != 0)
			{
				if (unevenIndex == i)
					return nums;

				unevenIndex--;
			}

			nums[i] += nums[unevenIndex];
			nums[unevenIndex] = nums[i] - nums[unevenIndex];
			nums[i] -= nums[unevenIndex];

			unevenIndex--;
		}

		return nums;
	}
}
