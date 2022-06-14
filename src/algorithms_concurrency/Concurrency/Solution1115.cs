namespace MyNihongo.Leetcode.Concurrency;

/// <summary>
/// The same instance of FooBar will be passed to two different threads:<br/>
/// - thread A will call foo(), while<br/>
/// - thread B will call bar().<br/><br/>
/// Modify the given program to output "foobar" n time
/// </summary>
internal sealed class Solution1115
{
	private readonly int n;
	private readonly AutoResetEvent _barEnded = new(true),
		_fooEnded = new(false);

	public Solution1115(int n)
	{
		this.n = n;
	}

	public void Foo(Action printFoo)
	{
		for (var i = 0; i < n; i++)
		{
			_barEnded.WaitOne();

			// printFoo() outputs "foo". Do not change or remove this line.
			printFoo();

			_barEnded.Reset();
			_fooEnded.Set();
		}
	}

	public void Bar(Action printBar)
	{
		for (var i = 0; i < n; i++)
		{
			_fooEnded.WaitOne();

			// printBar() outputs "bar". Do not change or remove this line.
			printBar();

			_fooEnded.Reset();
			_barEnded.Set();
		}
	}
}
