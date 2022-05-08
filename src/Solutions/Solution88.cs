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

	/// <summary>
	/// My original solution
	/// </summary>
	public static void Merge2(int[] nums1, int m, int[] nums2, int n)
	{
		if (n == 0)
			return;

		if (m == 0)
		{
			for (var i = 0; i < n; i++)
				nums1[i] = nums2[i];

			return;
		}

		for (int i = 0, j = 0; i < m || j < n;)
		{
			if (i >= m)
			{
				for (var k = i; k < nums1.Length; k++, j++)
					nums1[k] = nums2[j];

				return;
			}
			if (j >= n)
				return;

			if (nums1[i] <= nums2[j])
			{
				i++;
			}
			else
			{
				var jStart = j++;
				for (; j < n; j++)
				{
					if (nums2[j] != nums2[j - 1])
						break;
				}

				var moveRange = j - jStart;
				for (var k = m - 1; k >= i; k--)
					nums1[k + moveRange] = nums1[k];

				for (var k = 0; k < moveRange; k++)
					nums1[i + k] = nums2[jStart];

				m += moveRange;
				i += moveRange;
			}
		}
	}
}
