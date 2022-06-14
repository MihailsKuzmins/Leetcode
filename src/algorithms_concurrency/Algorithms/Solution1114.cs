// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// The same instance of Foo will be passed to three different threads. Thread A will call first(), thread B will call second(), and thread C will call third(). Design a mechanism and modify the program to ensure that second() is executed after first(), and third() is executed after second().
/// </summary>
public sealed class Solution1114
{
	private readonly AutoResetEvent
		_firstEnded = new(false),
		_secondEnded = new(false);

	public void First(Action printFirst)
	{
		// printFirst() outputs "first". Do not change or remove this line.
		printFirst();
		_firstEnded.Set();
	}

	public void Second(Action printSecond)
	{
		_firstEnded.WaitOne();

		// printSecond() outputs "second". Do not change or remove this line.
		printSecond();
		_secondEnded.Set();
	}

	public void Third(Action printThird)
	{
		_secondEnded.WaitOne();

		// printThird() outputs "third". Do not change or remove this line.
		printThird();
	}
}
