namespace MyNihongo.Leetcode.Solutions;

public sealed class Solution905
{
	public static int[] SortArrayByParity(int[] nums)
	{
		if (nums.Length == 1)
			return nums;

		for (int i = 0, evenIndex = 0; i < nums.Length; i++)
		{
			if (nums[i] % 2 != 0)
				continue;

			if (evenIndex != i)
			{
				nums[i] += nums[evenIndex];
				nums[evenIndex] = nums[i] - nums[evenIndex];
				nums[i] -= nums[evenIndex];
			}

			evenIndex++;
		}

		return nums;
	}
}
