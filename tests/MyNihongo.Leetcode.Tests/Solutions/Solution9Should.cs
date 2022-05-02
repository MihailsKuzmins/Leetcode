﻿namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution9Should
{
	[Fact]
	public void Case1()
	{
		const int input = 121;

		var result = new Solution9()
			.IsPalindrome(input);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		const int input = -121;

		var result = new Solution9()
			.IsPalindrome(input);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case3()
	{
		const int input = 10;

		var result = new Solution9()
			.IsPalindrome(input);

		result
			.Should()
			.BeFalse();
	}
}
