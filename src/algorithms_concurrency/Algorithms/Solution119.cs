namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given an integer rowIndex, return the rowIndex <b>(0-indexed)</b> row of the <b>Pascal's triangle</b>.<br/>
/// In <b>Pascal's triangle</b>, each number is the sum of the two numbers directly above
/// </summary>
public sealed class Solution119
{
	public static IList<int> GetRow(int rowIndex)
	{
		var arr = new int[rowIndex + 1];
		var len = arr.Length % 2 != 0
			? arr.Length / 2 + 1
			: arr.Length / 2;

		for (var i = 0; i < len; i++)
		{
			var num = 1L;

			// According to the Pascal triangle formula
			for (var j = 0; j < i; j++)
			{
				num /= j + 1;
				num *= rowIndex - j;
			}

			arr[i] = (int)num;
			arr[^(i + 1)] = (int)num;
		}

		return arr;
	}
}
