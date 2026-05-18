namespace MyApp2.Multithreading;

using System;
using System.Threading;

public class Multithreading01
{
    public static void Run()
    {
        Thread t1 = Thread.CurrentThread;
        t1.Name = "Main Thread";
        System.Console.WriteLine($"Current thread is {Thread.CurrentThread.Name}");
    }
}