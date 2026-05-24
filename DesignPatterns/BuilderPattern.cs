namespace MyApp2.DesignPatterns;

public class Calc(int x = 0)
{
    public int Number { get; private set; } = x;

    public Calc Add(int x)
    {
        Number += x;
        return this;
    }

     public Calc Sub(int x)
    {
        Number -= x;
        return this;
    }

     public Calc Mul(int x)
    {
        Number *= x;
        return this;
    }

     public int Result()
    {
        return Number;
    }


}

public static class BuilderPattern
{
    public static void Run()
    {
        var result = new Calc(8).Add(20).Sub(9).Mul(4).Result();
        System.Console.WriteLine(result);
    }
}
