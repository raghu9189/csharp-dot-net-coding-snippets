using System.Text.Json;
namespace MyApp2.Basics;

interface IWorkable
{
    const int num1 = 2;
    string Name { get; set; }

    double Salary {get; set;}
    abstract void Working();
}

public static class StringExtensions 
{
    public static bool IsEmail(this string value)
    {
        return value.Contains("@");
    }
}
public static class IntExtentions
{
    public static bool IsEven(this int value)
    {
        return value % 2 == 0;
    }
}


struct EmployeeStruct: IWorkable, IWorker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public EmployeeStruct(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public readonly void Working()
    {
        System.Console.WriteLine("Working..!");
    }

    public void Work()
    {
        throw new NotImplementedException();
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }
}

file interface IWorker
{
    void Work();
    void Eat();
}
public class Practice01
{
    public static void Run()
    {
        var e1 = new EmployeeStruct(1, "Raghu");
        var e2 = new EmployeeStruct()
        {
            Id = 2,
            Name = "Ramya"
        };
        e2 = e1;
        e1.Id = 1;
        e1.Working();
        try
        {
        e1.Work();
            
        }
        catch (System.NotImplementedException ex)
        {
            
            System.Console.WriteLine(ex.Message);
        }
        // e1.Eat();
        System.Console.WriteLine(JsonSerializer.Serialize(e1));
        System.Console.WriteLine(JsonSerializer.Serialize(e2));
        System.Console.WriteLine(e2.Name.IsEmail());
        int num1 = 35;
        System.Console.WriteLine(num1.IsEven());
    }
}