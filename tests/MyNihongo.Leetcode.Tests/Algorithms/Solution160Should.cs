namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution160Should
{
	[Fact]
	public void Case1()
	{
		ListNode c1 = new(5), c2 = new(4, c1), c3 = new(8, c2),
			a1 = new(1, c3), a2 = new(4, a1),
			b1 = new(1, c3), b2 = new(6, b1), b3 = new(5, b2);

		var result = Solution160.GetIntersectionNode(a2, b3);

		result
			.Should()
			.Be(c3);
	}

	[Fact]
	public void Case2()
	{
		ListNode c1 = new(2), c2 = new(4, c1),
			a1 = new(1, c2), a2 = new(9, a1), a3 = new(1, a2),
			b1 = new(3, c2);

		var result = Solution160.GetIntersectionNode(a3, b1);

		result
			.Should()
			.Be(c2);
	}

	[Fact]
	public void Case3()
	{
		ListNode a1 = new(4), a2 = new(6, a1), a3 = new(2, a2),
			b1 = new(5), b2 = new(1, b1);

		var result = Solution160.GetIntersectionNode(a3, b2);

		result
			.Should()
			.BeNull();
	}
}
