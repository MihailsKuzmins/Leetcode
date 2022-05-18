namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer numRows, return the first numRows of <b>Pascal's triangle</b>.<br/>
/// In <b>Pascal's triangle</b>, each number is the sum of the two numbers directly above.
/// </summary>
public sealed class Solution118
{
	public static IList<IList<int>> Generate(int numRows)
	{
		var list = new IList<int>[numRows];
		list[0] = new[] { 1 };

		for (var i = 1; i < numRows; i++)
		{
			var curr = list[i] = new int[list[i - 1].Count + 1];
			curr[0] = 1;
			curr[^1] = 1;

			var len = curr.Count % 2 != 0
				? curr.Count / 2 + 1
				: curr.Count / 2;

			for (var j = 1; j < len; j++)
			{
				var num = list[i - 1][j - 1] + list[i - 1][j];
				curr[j] = num;
				curr[^(j + 1)] = num;
			}
		}

		return list;
	}
}
