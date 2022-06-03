namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution203Should
{
	[Fact]
	public void Case1()
	{
		var input = CreateLinkedList(new[] { 1, 2, 6, 3, 4, 5, 6 });
		const int val = 6;

		var expected = new [] { 1, 2, 3, 4, 5 };

		var root = Solution203.RemoveElements(input, val);
		var result = CreateValueArray(root);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		const int val = 1;

		var result = Solution203.RemoveElements(null, val);

		result
			.Should()
			.BeNull();
	}

	[Fact]
	public void Case3()
	{
		var input = CreateLinkedList(new[] { 7, 7, 7, 7 });
		const int val = 7;

		var result = Solution203.RemoveElements(input, val);

		result
			.Should()
			.BeNull();
	}
}
