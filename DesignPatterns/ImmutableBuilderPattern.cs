namespace MyApp2.DesignPatterns;

public class ImmutableCalc
{
    public int Number { get; private set;}

    public ImmutableCalc(int x = 0)
    {
        Number = x;
    }

    public ImmutableCalc Add(int x)
    {
        return new ImmutableCalc(Number + x);
    }
    public ImmutableCalc Sub(int x)
    {
        return new ImmutableCalc(Number - x);
    }
    public ImmutableCalc Mul(int x)
    {
        return new ImmutableCalc(Number * x);
    }

    public int Result()
    {
        return Number;
    }
}

public static class ImmutableBuilderPattern
{
    public static void Run()
    {
        var result = new ImmutableCalc(10)
            .Add(20)
            .Sub(10)
            .Mul(20)
            .Result();
        System.Console.WriteLine(result);

    }   
}