class SafeList<T>
{
    private T[] items;

    public SafeList(T[] items)
    {
        this.items = items;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= items.Length)
            return default;

        return items[index];
    }
}