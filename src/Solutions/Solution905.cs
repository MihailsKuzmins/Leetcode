namespace MyNihongo.Leetcode.Solutions;

public sealed class Solution905
{
	public static int[] SortArrayByParity(int[] nums)
	{
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] % 2 == 0)
				continue;

			var isMoved = false;
			for (var j = i + 1; j < nums.Length; j++)
			{
				if (nums[j] % 2 != 0)
					continue;

				nums[i] += nums[j];
				nums[j] = nums[i] - nums[j];
				nums[i] -= nums[j];

				isMoved = true;
				break;
			}

			if (!isMoved)
				break;
		}

		return nums;
	}
}
