namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given a non-negative integer x, compute and return the square root of x.<br/>
/// Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.<br/>
/// Note: You are not allowed to use any built-in exponent function or operator, such as pow(x, 0.5) or x ** 0.5.
/// </summary>
public sealed class Solution69
{
	public static int MySqrt(int x)
	{
		int start = 0, end = x;
		while (start <= end)
		{
			long num = (start + end) / 2;
			var pow2 = num * num;

			if (pow2 > x)
				end = (int)num - 1;
			else if (pow2 < x)
				start = (int)num + 1;
			else
				return (int)num;
		}

		return end;
	}
}
