
public class MyStack_LeetCode_225
{
    private readonly List<int> _list;
    private Queue<int> _queue;

    public MyStack_LeetCode_225()
    {
        _list = new List<int>();
        _queue = new Queue<int>();
    }

    public void Push(int x)
    {
        //Every push is O(n), except the first one.
        _list.Add(x);

        if (_queue.Count == 0)
        {
            _queue.Enqueue(x);
        }
        else
        {
            _queue = new Queue<int>();

            for (int i = _list.Count - 1; i >= 0; i--)
            {
                _queue.Enqueue(_list[i]);
            }
        }
    }

    public int Pop()
    {
        if (_list.Count > 0)
            _list.RemoveAt(_list.Count - 1);

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

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */