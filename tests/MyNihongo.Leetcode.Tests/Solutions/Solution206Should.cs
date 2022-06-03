namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution206Should
{
	[Fact]
	public void Case1()
	{
		var input = CreateLinkedList(new[] { 1, 2, 3, 4, 5 });
		var expected = new[] { 5, 4, 3, 2, 1 };

		var node = Solution206.ReverseList(input);
		var result = CreateValueArray(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		var input = CreateLinkedList(new[] { 1, 2 });
		var expected = new[] { 2, 1 };

		var node = Solution206.ReverseList(input);
		var result = CreateValueArray(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case3()
	{
		var node = Solution206.ReverseList(null);
		var result = CreateValueArray(node);

		result
			.Should()
			.BeEmpty();
	}
}
