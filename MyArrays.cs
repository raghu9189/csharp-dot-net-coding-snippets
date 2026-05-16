// using System.Linq;
using System.Threading.Tasks;

class MyArrays
{
    static public void AllArrays()
    {
        string[] cars = ["Volvo"];
        int[] scores = [12, 2, 3, 90, 102, 34, 78, 24, 98];
        foreach (var car in cars)
        {
            System.Console.WriteLine(car);
        }
        System.Console.WriteLine(cars[0]);

        // Sort the array
        Array.Sort(scores);
        foreach (var score in scores)
        {
            System.Console.WriteLine(score);
        }

        // Linq methods
        System.Console.WriteLine(scores.Min()); // Return smallest value
        System.Console.WriteLine(scores.Max()); // Return smallest value
        System.Console.WriteLine(scores.Sum()); // Return smallest value

        // Multi Dimentional arrays

        int[,] matrix = new int[2, 2] { { 2, 3 }, { 1, 3 } };

        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < 2; column++)
            {
                System.Console.WriteLine(matrix[row, column]);
            }
        }

        // Array methods
        int[] origScores = [12, 2, 3, 90, 102, 34, 78, 24, 98];
        int foundIndex = Array.IndexOf(origScores, 90);
        System.Console.WriteLine($"Index Found at {foundIndex}");
        bool isExists = Array.Exists(scores, x => x == 3);
        System.Console.WriteLine(isExists);
        var role = "admin";
        var message = role switch
        {
            "admin" => "Hi sir",
            "user" => "Hello user",
            "manager" => "hello Manager",
            _ => "unknown"
        };
        System.Console.WriteLine(message);


        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}