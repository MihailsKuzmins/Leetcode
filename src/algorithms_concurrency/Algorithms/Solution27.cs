namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.<br/>
/// Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.<br/>
/// Return k after placing the final result in the first k slots of nums.<br/>
/// Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
/// </summary>
public sealed class Solution27
{
	public static int RemoveElement(int[] nums, int val)
	{
		var length = 0;
		for (var i = 0; i < nums.Length; i++)
		{
			if (nums[i] == val)
				continue;

			nums[length] = nums[i];
			length++;
		}

		return length;
	}
}
