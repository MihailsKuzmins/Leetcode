namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution141Should
{
	[Fact]
	public void Case1()
	{
		Solution141.ListNode item3 = new(-4), item2 = new(0, item3), item1 = new(2, item2),
			item0 = new(3, item1);
		item3.next = item1;

		var result = Solution141.HasCycle(item0);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		Solution141.ListNode item1 = new(2), item0 = new(1, item1);
		item1.next = item0;

		var result = Solution141.HasCycle(item0);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case3()
	{
		Solution141.ListNode item0 = new(1);

		var result = Solution141.HasCycle(item0);

		result
			.Should()
			.BeFalse();
	}
}
