class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static T FindMax<T>(T[] items) where T : IComparable<T>
    {
        T max = items[0];

        for (int i = 1; i < items.Length; i++)
        {
            if (items[i].CompareTo(max) > 0)
            {
                max = items[i];
            }
        }

        return max;
    }
}