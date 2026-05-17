using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

class DictionaryDS
{
    // Lambda Function
    static Func<int, int> Add = x => x+2;

    static int Mult(int x,[Optional] int y)
    {
        return x * y;
    }

    // Out Params
    static void ModifyOriginalNumber(out int number)
    {
        number = 10;
    }

    // Async Function
    public static void Run()
    {
        Dictionary<string, string> teachers = new()
        {
            { "Math", "Raghu Ram" }
        };

        teachers.Add("Physics", "Sravani");
        teachers.Add("Telugu", "Raju");
        foreach (KeyValuePair<string, string> teacher in teachers)
        {
            System.Console.WriteLine(teacher.Value);
        }
        teachers["Telugu"] = "Godavari"; 
        teachers.Remove("Physics");
        foreach (var subject in teachers.Keys)
        {
            System.Console.WriteLine(teachers[subject]);
        }
        System.Console.WriteLine($"Teachers count {teachers.Count}");
        System.Console.WriteLine($"Add {Add(2)}");
        System.Console.WriteLine($"Multiply {Mult(x: 30, y: 90)}");

        int MagicNumber = 0;
        System.Console.WriteLine($"Before {MagicNumber}");
        ModifyOriginalNumber(out MagicNumber);
        System.Console.WriteLine($"After {MagicNumber}");

    }
}