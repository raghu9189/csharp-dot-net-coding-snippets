namespace MyApp2.Basics;

struct MyStruct
{
    public int Id;
}

enum MyEnum
{
    First = 1,
    Second = 2
}

class MyClass
{
}

public class DataTypesInDepth
{
    public static void Run()
    {
        // unsigned data types
        uint uNum = 23U;
        System.Console.WriteLine(uNum);

        // Default Types
        // Value Types
        Console.WriteLine(default(int));          
        Console.WriteLine(default(DateTime));     
        Console.WriteLine(default(char));         
        Console.WriteLine(default(Guid));         
        Console.WriteLine(default(MyStruct));     
        Console.WriteLine(default(MyEnum));       

        // Reference Types
        // Console.WriteLine(default(object));       
        // Console.WriteLine(default(string));       
        // Console.WriteLine(default(MyClass));      
        // Console.WriteLine(default(IDisposable));  
        // Console.WriteLine(default(dynamic));  

        // print their sizes
        Console.WriteLine(sizeof(bool));
        Console.WriteLine(sizeof(byte));
        Console.WriteLine(sizeof(sbyte));
        Console.WriteLine(sizeof(char));
        Console.WriteLine(sizeof(short));
        Console.WriteLine(sizeof(ushort));
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(uint));
        Console.WriteLine(sizeof(float));
        Console.WriteLine(sizeof(long));
        Console.WriteLine(sizeof(ulong));
        Console.WriteLine(sizeof(double));
        Console.WriteLine(sizeof(decimal));
        
    }
}