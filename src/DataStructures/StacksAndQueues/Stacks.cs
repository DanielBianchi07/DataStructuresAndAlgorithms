using System.Collections;

namespace DataStructures.StacksAndQueues;

public class Stack
{
    private int p_index;
    private ArrayList list;

    public Stack()
    {
        list = new ArrayList();
        p_index = -1;
    }

    public int count => list.Count;

    public void push(Object item)
    {
        list.Add(item);
        p_index++;
    }

    public Object pop()
    {
        Object obj = list[p_index];
        list.RemoveAt(p_index);
        p_index--;
        return obj;
    }

    public void clear()
    {
        list.Clear();
        p_index = -1;
    }

    public Object peek()
    {
        return list[p_index];   
    }
}