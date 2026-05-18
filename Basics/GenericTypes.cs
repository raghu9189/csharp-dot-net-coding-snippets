
namespace MyApp2.Basics;

// Generic class
public class Box<T>
{
    public T? Value {get; set;}
    public Box(T v){
        this.Value = v;
    }
    public Box(){}

}



public class GenericTypes
{
    public static void Run()
    {
        Box<int> intBox = new()
        {
            Value = 23
        };

        intBox.Value = 90;

        var stringBox = new Box<string>("Big");
        stringBox.Value = "Small";

        System.Console.WriteLine($"Int value {intBox.Value} string value {stringBox.Value}");
        PrintValue<int>(2);
        PrintValue<string>("Hello");
        PrintValue<float>(2.5F);
        PrintValue<decimal>(2500.90M);


    }

    // Generic Method
    public static void PrintValue<T>(T value)
    {
        System.Console.WriteLine($"The value is {value}");
    }

}