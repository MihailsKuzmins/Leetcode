namespace MyNihongo.Leetcode.Solutions;

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

		if (a.Length > b.Length)
			(a, b) = (b, a);

		var result = new System.Text.StringBuilder(b.Length);
		var indexDifference = b.Length - a.Length;
		var transferOne = false;
		for (var i = a.Length - 1; i >= 0; i--)
		{
			switch (a[i])
			{
				case '0':
					switch (b[i + indexDifference])
					{
						case '0':
							result.Insert(0, transferOne ? '1' : '0');
							transferOne = false;
							break;
						case '1':
							if (transferOne)
							{
								result.Insert(0, '0');
							}
							else
							{
								result.Insert(0, '1');
								transferOne = false;
							}
							break;
					}
					break;
				case '1':
					switch (b[i + indexDifference])
					{
						case '0':
							if (transferOne)
							{
								result.Insert(0, '0');
							}
							else
							{
								result.Insert(0, '1');
								transferOne = false;
							}
							break;
						case '1':
							result.Insert(0, transferOne ? '1' : '0');
							transferOne = true;
							break;
					}
					break;
			}
		}

		for (var i = indexDifference - 1; i >= 0; i--)
		{
			switch (b[i])
			{
				case '0':
					result.Insert(0, transferOne ? '1' : '0');
					transferOne = false;
					break;
				case '1':
					if (transferOne)
					{
						result.Insert(0, '0');
					}
					else
					{
						result.Insert(0, '1');
						transferOne = false;
					}
					break;
			}
		}

		if (transferOne)
			result.Insert(0, '1');

		return result.ToString();
	}
}
