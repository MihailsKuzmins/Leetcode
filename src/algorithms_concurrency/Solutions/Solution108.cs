// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.<br/>
/// A <b>height-balanced</b> binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.
/// </summary>
public sealed class Solution108
{
	// TODO: iterative
	public static TreeNode? SortedArrayToBST(int[] nums)
	{
		return nums.Length != 0
			? GetNode(nums, 0, nums.Length - 1)
			: null;

		static TreeNode? GetNode(in int[] nums, in int start, in int end)
		{
			if (start > end)
				return null;

			var med = (start + end) / 2;
			var right = GetNode(nums, med + 1, end);
			var left = GetNode(nums, start, med - 1);

			return new TreeNode(nums[med])
			{
				right = right,
				left = left
			};
		}
	}
}
