namespace Lab_05_1;

public class MyDictionary<TKey, TValue>
{
    private TKey[] keys;
    private TValue[] values;

    public MyDictionary()
    {
        keys = new TKey[0];
        values = new TValue[0];
    }

    public int Count
    {
        get { return keys.Length; }
    }

    public void Add(TKey key, TValue value)
    {
        Array.Resize(ref keys, keys.Length + 1);
        Array.Resize(ref values, values.Length + 1);

        keys[keys.Length - 1] = key;
        values[values.Length - 1] = value;
    }

    public TValue this[TKey key]
    {
        get
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                    return values[i];
            }

            throw new KeyNotFoundException();
        }
        set
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    values[i] = value;
                    return;
                }
            }

            throw new KeyNotFoundException();
        }
    }

    public void Iterate()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            Console.WriteLine("Key: " + keys[i] + ", Value: " + values[i]);
        }
    }
}