namespace MyApp2.Basics;

public class ReferenceExcercise
{

    static void StringEqualityTypes()
    {
        string a = "hello";
        string b = "hello";
        string c = new string("hello".ToCharArray());

        // == 
        /* 
            1. for string, compares content
            2. overload operator
            3. Not normal reference operator
        */
        System.Console.WriteLine($" a == b {a == b}"); // true
        System.Console.WriteLine($" a == c {a == c}"); // true

        // .Equals()
        /* 
            1. compares content
            2. case sensitivity by default
        */
         System.Console.Write("Equals() ");
        System.Console.WriteLine(a.Equals(b, StringComparison.OrdinalIgnoreCase)); // true

        // ReferenceEquals()
        /* 
            1. Check actual memory reference
            2. Returns only true if both objects pointing to the same object
        */
         System.Console.Write("ReferenceEquals() ");
        System.Console.WriteLine(object.ReferenceEquals(a, c)); // false
    }
    
    static void GlobalUniqueIdentifierExampleGUIDorUUID()
    {
        var guid = Guid.NewGuid();
        System.Console.WriteLine($"New GUID: {guid}");
    }
    public static void Run()
    {
        int[] sourceArray = new int[5] {1, 2, 3, 4, 5};
        int[] destinationArray = new int[5];

        // shallow copy * values types are copied but reference types still point to original
        int[] arr2 = sourceArray;
        arr2[0] = 90;
        sourceArray.CopyTo(destinationArray);
        foreach (var item in sourceArray)
        {
            System.Console.WriteLine("ITEM: " + item);
        }

        // check equalities
        System.Console.WriteLine(sourceArray.Equals(arr2));

        // check values equalities SIZE + VALUES
        System.Console.WriteLine(sourceArray.SequenceEqual(arr2));

        // Multi Dimentional Array
        int[,] twoDArray = new int[2,3] {{1,2,3}, {2,3,4}};
        System.Console.WriteLine($" {twoDArray[0, 0]} {twoDArray[0, 1]} {twoDArray[0, 2]}");

        // Linq Range()
        int[] sequence = Enumerable.Range(1, 10).ToArray();
        foreach (var item in sequence)
        {
            System.Console.WriteLine(item);
        }

        // arrays implements IEnumerables
        IEnumerable<int> evenNums = new int[] {1,2,3};
        System.Console.WriteLine(evenNums.ElementAt(0));

        System.Console.WriteLine($"My Fav day is {WeekDay.Saturday}");

        // UUID
        string myUniqueNum = new Guid().ToString();
        System.Console.WriteLine(myUniqueNum);

        // Object reference equality check

        string name1 = "Raghu";
        string name2 = "Raghu";

        System.Console.WriteLine(name1 == name2);
        System.Console.WriteLine(object.ReferenceEquals(name1, name2));

        StringEqualityTypes();
        GlobalUniqueIdentifierExampleGUIDorUUID();

    }
}