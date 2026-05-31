using BenchmarkDotNet.Attributes;

namespace MyApp2.PerformanceTest;

using BenchmarkDotNet.Attributes;

public class ListBenchmark
{
    [Benchmark]
    public void ListAdd()
    {
        var list = new List<int>();
        for (int i = 0; i < 10000; i++)
            list.Add(i);
    }

    [Benchmark]
    public void ArrayFill()
    {
        var arr = new int[10000];
        for (int i = 0; i < 10000; i++)
            arr[i] = i;
    }
}