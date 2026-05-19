using System.Data.Common;
using System.Text.Json;

namespace MyApp2.Basics;

public record User(string Name, int Id);
public class RecordDs
{
    public static void Run()
    {
        var u1 = new User("Raghu", 12);
        var u2 = new User("Raghu", 12);
        var u3 = new User("Ramya", 90);
        // string json = JsonSerializer.Serialize(u1);          Object To JSON
        // User u3 = JsonSerializer.Deserialize<User>(json);    JSON To Object
        Console.WriteLine(u1);
    }
}