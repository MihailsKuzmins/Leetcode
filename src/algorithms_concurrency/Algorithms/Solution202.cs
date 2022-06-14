namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Write an algorithm to determine if a number n is happy.<br/>
/// A <b>happy number</b> is a number defined by the following process:<br/>
/// - Starting with any positive integer, replace the number by the sum of the squares of its digits.<br/>
/// - Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.<br/>
/// - Those numbers for which this process ends in 1 are happy.<br/><br/>
/// Return true if n is a happy number, and false if not.
/// </summary>
public sealed class Solution202
{
	public static bool IsHappy(int n)
	{
		var set = new HashSet<int>();

		while (n != 1)
		{
			if (set.Contains(n))
				return false;

			set.Add(n);
			var newN = 0;

			while (n > 0)
			{
				var num = n % 10;
				newN += num * num;
				n /= 10;
			}

			n = newN;
		}

		return true;
	}
}
