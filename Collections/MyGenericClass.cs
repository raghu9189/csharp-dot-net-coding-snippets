namespace MyApp2.Collections;

class MyStorage<T>
{
    private T _item;

    public MyStorage(T value)
    {
        _item = value;
    }

    public void SetStorage(T value)
    {
        _item = value;
    }

    public T GetStorage()
    {
        return _item;
    }
}

static class MyGenericClass
{
    public static void Run()
    {
        MyStorage<int> myStorage = new(256);
        myStorage.SetStorage(1024);
        System.Console.WriteLine(myStorage.GetStorage());
    }
}