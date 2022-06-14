namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given two binary strings a and b, return their <i>sum as a binary string</i>.
/// </summary>
public sealed class Solution67
{
	public static string AddBinary(string a, string b)
	{
		if (a == "0")
			return b;
		if (b == "0")
			return a;

		int i = a.Length - 1, j = b.Length - 1, carry = 0;
		var result = new System.Text.StringBuilder(b.Length);

		while (i >= 0 || j >= 0)
		{
			var sum = carry;
			if (i >= 0)
				sum += a[i--] - '0';
			if (j >= 0)
				sum += b[j--] - '0';

			result.Insert(0, sum % 2);
			carry = sum / 2;
		}

		if (carry != 0)
			result.Insert(0, '1');

		return result.ToString();
	}
}
