namespace MyApp2.Multithreading;

using System;
using System.Threading;

// Simulate thread sleep
public class Multithreading02
{

    static void Test1()
    {
        for (int i = 0; i < 25; i++)
        {
            System.Console.WriteLine($"Test1: {i}");
        }
    }
    static void Test2()
    {
        for (int i = 0; i < 25; i++)
        {
            System.Console.WriteLine($"Test2: {i}");
            if(i == 15)
            {
                System.Console.WriteLine("Went To Sleep ========");
                Thread.Sleep(9000);
                System.Console.WriteLine("Woke up =============");
            }
        }
    }
    static void Test3()
    {
        for (int i = 0; i < 25; i++)
        {
            System.Console.WriteLine($"Test3: {i}");
        }
    }

    public static void Run()
    {
        Thread T1 = new Thread(Test1);
        Thread T2 = new Thread(Test2);
        Thread T3 = new Thread(Test3);
        
        T1.Start();
        T2.Start();
        T3.Start();

        T1.Join();
        T2.Join();
        T3.Join();
        System.Console.WriteLine("Main thread Exiting..");

    }
}