namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution88Should
{
	[Fact]
	public void Case1()
	{
		const int len1 = 3, len2 = 3;
		int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 },
			expected = { 1, 2, 2, 3, 5, 6 };

		Solution88.Merge(nums1, len1, nums2, len2);

		nums1
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		const int len1 = 1, len2 = 0;
		int[] nums1 = { 1 }, nums2 = Array.Empty<int>(),
			expected = { 1 };

		Solution88.Merge(nums1, len1, nums2, len2);

		nums1
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case3()
	{
		const int len1 = 0, len2 = 1;
		int[] nums1 = { 0 }, nums2 = { 1 },
			expected = { 1 };

		Solution88.Merge(nums1, len1, nums2, len2);

		nums1
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case4()
	{
		const int len1 = 1, len2 = 1;
		int[] nums1 = { 2, 0 }, nums2 = { 1 },
			expected = { 1, 2 };

		Solution88.Merge(nums1, len1, nums2, len2);

		nums1
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
