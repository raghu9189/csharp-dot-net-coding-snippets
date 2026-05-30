using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json;

namespace MyApp2.Collections;

#nullable disable
public static class TypesOfCollections2
{
    public static void Run()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(2);
        // int num = arrayList[0]; // can not assign object to int (Unboxing problem)
        int num1 = (int)arrayList[0]; // explicit type casting needed;
        foreach (var item in arrayList)
        {
            System.Console.WriteLine(item);
        }

        // Non Generic collections like
        // ArrayList, Hashtable, Queue, Stack not type safe plus they store it as object needed Boxing/Unboxing.

        var myStack = new Stack<int>();
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);

        int removedItem = myStack.Pop();
        System.Console.WriteLine("Item removed "+removedItem);

        int topElement = myStack.Peek();
        System.Console.WriteLine("Top element "+topElement);

        int size = myStack.Count;
        System.Console.WriteLine("Size of stack "+size);

        System.Console.WriteLine(JsonSerializer.Serialize(myStack.AsEnumerable())); // AsEnumerable() → MOST optimized

        myStack.Clear();

        System.Console.WriteLine(JsonSerializer.Serialize(myStack.ToArray()));
    }
}
