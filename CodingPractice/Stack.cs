class Stack
{
    private int _position;
    private object[] data = new object[10];

    public void Push(object obj)
    {
        data[_position++] = obj; 
    }
    public object Pop()
    {
        return data[--_position];
    }
}