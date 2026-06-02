

namespace MyApp2.PerformanceTest;


public class ListBenchmark
{

    public void ListAdd()
    {
        var list = new List<int>();
        for (int i = 0; i < 10000; i++)
            list.Add(i);
    }


    public void ArrayFill()
    {
        var arr = new int[10000];
        for (int i = 0; i < 10000; i++)
            arr[i] = i;
    }
}