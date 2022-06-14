namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).
/// </summary>
public sealed class Solution225
{
	private readonly Queue<int> _queue = new();

    public void Push(int x)
    {
	    _queue.Enqueue(x);

        // Now we need to move the last element to the front of the queue
        // moving the present elements to the back of the queue
        for (int i = 0, count = _queue.Count - 1; i < count; i++)
        {
	        var val = _queue.Dequeue();
            _queue.Enqueue(val);
        }
    }

    public int Pop()
    {
        return _queue.Dequeue();
    }

    public int Top()
    {
	    return _queue.Peek();
    }

    public bool Empty()
    {
	    return _queue.Count == 0;
    }
}
