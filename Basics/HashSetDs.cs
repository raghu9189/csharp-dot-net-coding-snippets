namespace MyApp2.Basics;
public class HashSetDs
{
    public static void Run()
    {
        var numbers = new int[] {2,3,4,5};
        var userIds = new HashSet<int>();
        userIds.Add(23);
        userIds.Add(4);
        userIds.Add(4);
        userIds.Remove(4);
        userIds.CopyTo(numbers);
        foreach (var userId in userIds)
        {
            System.Console.WriteLine(userId);
        }
        foreach (var num in numbers)
        {
            System.Console.WriteLine(num);
        }

    }
}