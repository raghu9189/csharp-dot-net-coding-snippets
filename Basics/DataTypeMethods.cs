using System;
using System.Globalization;
namespace MyApp2.Basics;

class DataTypeMethods
{
    public static void Run()
    {
        int x, y, z;
        x = y = z = 23;
        const double PI = 3.141D;
        System.Console.WriteLine($"{x} {y} {z} {PI}");
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);
        System.Console.WriteLine(float.MinValue);

        // Convert string to int
        string age = "24";
        int myAge = Convert.ToInt32(age);
        System.Console.WriteLine($"Age is {myAge}");

        // Output remainder to the screen
        int num1 = 10, num2 = 4, remainder;
        remainder = num1 % num2;
        System.Console.WriteLine($"Remainder is {remainder}");

        // Console Input
        // string? name;
        // int? UserAge;
        // System.Console.Write("Enter your name:\n");
        // name = Console.ReadLine();
        // System.Console.WriteLine($"Hello {name}");

        // System.Console.Write("Enter your age: ");
        // UserAge = Convert.ToInt32(Console.ReadLine());
        // System.Console.WriteLine($"Age is {UserAge}");

        // Conditional Operator
        // string userIs = (UserAge >= 18) ?  "Adult" : "Minor";
        // System.Console.WriteLine(userIs);

        System.Console.WriteLine(CultureInfo.CurrentCulture);
        string path = "C:\\Documents\\Csharp\\Code";
        System.Console.WriteLine(path);
        path = @"C:\Documents\Csharp\Code"; // Verbatim string literal
        System.Console.WriteLine(path);

        // Lists

        var users = new List<string>();
        users.Add("Raghu");
        users.Add("Ramya");
        users.Add("Saisri");
        users.Add("Hari");

        users.ForEach(x => System.Console.WriteLine(x));

        int[] ranks = [1,2,3,4,5,6,7,8];
        Array.Clear(ranks, 1, 7);
        for (int i = 0; i < ranks.Length; i++)
        {
            ranks[i] = default;
        }
        foreach(var item in ranks)
        {
            System.Console.WriteLine($"Item {item}");
        }

    }
}