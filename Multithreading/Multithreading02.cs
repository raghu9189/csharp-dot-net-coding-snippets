namespace MyApp2.Multithreading;

using System;
using System.Threading;

public class Multithreading02
{

    static void Test1()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Test1: {i}");
        }
    }
    static void Test2()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Test2: {i}");
        }
    }
    static void Test3()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Test3: {i}");
        }
    }
    static void Test4()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Test4: {i}");
        }
    }

    public static void Run()
    {
        Test1();
        Test2();
        Test3();
        Test4();
    }
}