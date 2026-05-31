namespace MyApp2.Versions.Twelve;

public class Csharp12
{
    // 1. Primary Constructors
    public class Employee(string name)
    {
        public string Name { get; set;} = name;
    }

    // 2. Collection Expressions
    static void CollectionExpressionFeature()
    {
        int[] arr = [1,23,24,4];
        char[] charArr = ['1', '2', '3', '4'];
        string[] names = ["Raghu", "Ramya", "Saisri", "Divya"];
        List<int> numbers = [1,2,3,4];
        IEnumerable<int> myEnum = [1,2,3];
        ICollection<int> myCollec = [1,2,3];
        Dictionary<string, int> myDic = []; // Empty dict
        Stack<int> myStack = [];
        Queue<int> myQueue = [];
        Span<int> mySpan = arr.AsSpan(1,2);
        for (int i = 0; i < mySpan.Length; i++)
        {
            mySpan[i] = mySpan[i] * 10;
            System.Console.WriteLine(mySpan[i]);   
        }
        System.Console.WriteLine("=====Original Array=======");
        foreach (var item in arr)
        {
            System.Console.WriteLine(item);
        }
     }
    // 3. Ref Readonly parameters
    static void Print(ref readonly Employee person)
    {
        person.Name = "Ramu";
        Console.WriteLine(person.Name);
    }
    // 4. Default Lambda Parameters
    static void DefaultLambdaParams()
    {
        var Square = (int x = 2) => {return x*x;};
        System.Console.WriteLine(Square(3));
    }
    // 5. Alias Any Type
    // 6. Inline Arrays
    // 7. Experimental Arrays
    // 8. Interceptors
    public static void Run()
    {
        CollectionExpressionFeature();
        DefaultLambdaParams();
        Csharp12.Employee emp = new("Raghu");
        System.Console.WriteLine(emp.Name);
        Print(ref emp);
        System.Console.WriteLine(emp.Name);
    }
}