namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// You are given two integer arrays nums1 and nums2, sorted in <b>non-decreasing</b> order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.<br/>
/// <b>Merge</b> nums1 and nums2 into a single array sorted in <b>non-decreasing order</b>.<br/>
/// The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
/// </summary>
public sealed class Solution88
{
	public static void Merge(int[] nums1, int m, int[] nums2, int n)
	{
		while (n > 0)
		{
			if (m == 0)
			{
				while (n > 0)
				{
					nums1[m + n - 1] = nums2[n - 1];
					n--;
				}

				return;
			}

			if (nums1[m - 1] > nums2[n - 1])
			{
				nums1[m + n - 1] = nums1[m - 1];
				m--;
			}
			else
			{
				nums1[m + n - 1] = nums2[n - 1];
				n--;
			}
		}
	}
}
