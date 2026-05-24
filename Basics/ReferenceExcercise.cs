namespace MyApp2.Basics;

public class ReferenceExcercise
{
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
        string myUniqueNum = new Guid().ToString("D");
        System.Console.WriteLine(myUniqueNum);
        
    }
}