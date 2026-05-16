class ListDataStructures
{
    public static void PrintList(List<int> L)
    {
         for (int i = 0; i < L.Count; i++)
        {
            System.Console.WriteLine($"item at index {i} is {L[i]}");
        }
    }
    public static void Run()
    {
        // List
        var scores = new List<int>(){20, 30, 40, 50, 60};
        List<int> partialScores = [70, 80];
        PrintList(scores);

        // Check element
        bool itemExists = scores.Exists(x => x == 20);
        System.Console.WriteLine(itemExists);

        // Add item
        scores.Add(85);
        scores.Insert(2, 35);
        scores.AddRange(partialScores);
        scores.AddRange([90]);

        System.Console.WriteLine("after adding");
        PrintList(scores);
       
        // Remove Item
        scores.RemoveAt(2);
        System.Console.WriteLine("after removing");
        
        PrintList(scores);



    }
}

