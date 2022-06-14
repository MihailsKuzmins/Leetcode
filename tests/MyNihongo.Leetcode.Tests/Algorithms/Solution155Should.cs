namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution155Should
{
	[Fact]
	public void Case1()
	{
		var fixture = new MinStack();
		fixture.Push(-2);
		fixture.Push(0);
		fixture.Push(-3);

		fixture.GetMin()
			.Should()
			.Be(-3);

		fixture.Pop();

		fixture.Top()
			.Should()
			.Be(0);

		fixture.GetMin()
			.Should()
			.Be(-2);
	}
}
