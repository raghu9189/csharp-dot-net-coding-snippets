namespace MyApp2.DesignPatterns;

file class Singleton
{
    // step 1: create private static object of own class;
    private static Singleton? instance;

    // step 2: make constructor private
    private Singleton()
    {
        System.Console.WriteLine("Singleton Object created!");
    }
 
    // step: 3 global access method
    public static Singleton GetInstance()
    {
        if (instance is null)
        {
            instance = new Singleton();
        }
        return instance;
    }
}

public static class SingletonPattern
{
    public static void Run()
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();
        Console.WriteLine(s1 == s2);
    }
}