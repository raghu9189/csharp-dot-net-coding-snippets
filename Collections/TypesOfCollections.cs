using System.Collections.Generic;

namespace MyApp2.Collections;
public static class TypesOfCollections
{
    public static void Run()
    {

        // Original List
        var elements = new List<int>() {3, 4, 5, 6, 7, 8, 9, 10};

        // IEnumerable<T> → Read & Iterate Only
        IEnumerable<int> myElements = elements.AsEnumerable();
        System.Console.WriteLine("=====IEnumerable=====");
        foreach(var item in myElements)
        {
            System.Console.WriteLine(item);
        }

        // IEnumerator<T> → Actual Iterator
        IEnumerator<int> myIteretor = elements.GetEnumerator();
        System.Console.WriteLine("=====IEnumerator=====");
        while (myIteretor.MoveNext())
        {
            System.Console.WriteLine(myIteretor.Current);
        }

        // ICollection<T> → Add/Remove/Count
        ICollection<int> myCollection = elements;
        myCollection.Add(20);
        System.Console.WriteLine("=====ICollection=====");
        foreach (var item in myCollection)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("=====Original List=====");
        foreach (var item in elements)
        {
            System.Console.WriteLine(item);
        }

        // IList<T> → Index-Based Collection
        IList<int> myList = elements;
        myList.Add(30);
        System.Console.WriteLine("===== IList =====");
        System.Console.WriteLine(myList[^1]); // from End

        // List : IEnumerable, ICollection, IList
        // So List has ALL capabilities.

    }
}