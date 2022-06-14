namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// You are given a <b>sorted unique</b> integer array nums.<br/>
/// A <b>range</b> [a,b] is the set of all integers from a to b (inclusive).<br/>
/// Return the <b>smallest sorted</b> list of ranges that <b>cover all the numbers in the array exactly</b>. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.<br/>
/// Each range [a,b] in the list should be output as:<br/>
/// - "a->b" if a != b<br/>
/// - "a" if a == b
/// </summary>
public sealed class Solution228
{
	public static IList<string> SummaryRanges(int[] nums)
	{
		if (nums.Length == 0)
			return Array.Empty<string>();

		var list = new List<string>();
		return list;
	}
}
