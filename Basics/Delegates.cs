namespace MyApp2.Basics;

// Custom delegate
delegate int NumberProduct(int x, int y);

public class Delegates
{

    // Action (No return type)
    static readonly Action<string> Greet = (message) =>
    {
      System.Console.WriteLine($"Hello {message}");  
    }; 

    // Func (Return Type)
    static readonly Func<int, int, int> Add = (x, y) => { return x + y; };

    // Predicate (Bool Return Type)
    static readonly Predicate<int> IsEven = (number) => number % 2 == 0;

    // CallBack Function
    public static int Multiply(int x, int y)
    {
        return x * y;
    }  

    public static void Run()
    {

        // My Custom delegate
        NumberProduct mult =  new(Delegates.Multiply);

        // this is one way
        mult.Invoke(2, 4);

        // this is another way
        System.Console.WriteLine(mult(4, 3));
        System.Console.WriteLine(mult(4, 30));
        System.Console.WriteLine(mult(40, 3));

        Greet("Raghu");
        Greet("Ramya");
        Greet("Saisri");

        System.Console.WriteLine(Add(2,5));
        System.Console.WriteLine(Add(20,5));
        System.Console.WriteLine(Add(2,50));

        System.Console.WriteLine(IsEven(2));
        System.Console.WriteLine(IsEven(23));
        System.Console.WriteLine(IsEven(5));

        // Lambda expressions
        System.Console.WriteLine();


    }
}