namespace MyApp2.Basics;

public static class MathMethods
{
    public static void Run()
    {
        Random random = new();
        System.Console.WriteLine(random.Next(1,10));
        System.Console.WriteLine(random.Next(1,10));
        System.Console.WriteLine(random.Next(1,10));
        System.Console.WriteLine(Math.Ceiling(random.NextDouble()*1000000));
        System.Console.WriteLine(Convert.ToInt32(random.NextDouble()*1000000));
    }
}