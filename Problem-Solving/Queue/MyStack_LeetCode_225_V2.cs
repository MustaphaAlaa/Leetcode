
public class MyStack_LeetCode_225_V2
{
    private Queue<int> _queue;

    public MyStack_LeetCode_225_V2()
    {
        _queue = new Queue<int>();
    }

    public void Push(int x)
    {
        //Every push is O(n), except the first one. 
        _queue.Enqueue(x);
        for (int i = 0; i < _queue.Count - 1; i++)
        {
            _queue.Enqueue(_queue.Dequeue());
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

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */