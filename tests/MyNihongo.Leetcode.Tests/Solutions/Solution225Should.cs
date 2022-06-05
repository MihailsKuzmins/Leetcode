namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution225Should
{
	[Fact]
	public void Case1()
	{
		var fixture = new Solution225();
		fixture.Push(1);
		fixture.Push(2);

		fixture.Top()
			.Should()
			.Be(2);

		fixture.Pop()
			.Should()
			.Be(2);

		fixture.Empty()
			.Should()
			.BeFalse();
	}
}
