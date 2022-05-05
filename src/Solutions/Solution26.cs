namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.<br/>
/// Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.<br/>
/// Return k after placing the final result in the first k slots of nums.<br/>
/// Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
/// </summary>
public sealed class Solution26
{
	public static int RemoveDuplicates(int[] nums)
	{
		if (nums.Length < 2)
			return nums.Length;

		var uniqueIndex = 1;
		for (var i = uniqueIndex; i < nums.Length; i++)
		{
			if (nums[i] == nums[i - 1])
				continue;

			nums[uniqueIndex] = nums[i];
			uniqueIndex++;
		}

		return uniqueIndex;
	}
}
