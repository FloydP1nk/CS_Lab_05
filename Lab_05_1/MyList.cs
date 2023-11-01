namespace Lab_05_1;

public class MyList<Type>
{
    private Type[] array;

    public MyList()
    {
        array = new Type[0];
    }

    public Type this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }

    public int Count
    {
        get { return array.Length; }
    }
    
    public void Add(Type item)
    {
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = item;
    }

}