namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution203Should
{
	[Fact]
	public void Case1()
	{
		var input = CreateLinkedList(new[] { 1, 2, 6, 3, 4, 5, 6 });
		const int val = 6;

		var result = Solution203.RemoveElements(input, val);

		result
			.Should()
			.BeNull();
	}
}
