using System.Text;

namespace MyApp2.Basics;

public class MyUser
{
    public string Name { get; set; }
    public int Id { get; set; }
}

public class StringOperations
{
    public static void Run()
    {
        var userName = "  Raghuvaran";
        userName = userName.Trim();
        string firstName = userName[0..5];

        StringBuilder UserName = new("RaghuBallu");
        UserName.AppendJoin("", ", ");
        System.Console.WriteLine(firstName);
        System.Console.WriteLine(UserName);

        // string format
        string sentence = String.Format("My Name is {0} and i do {1}", "Raghu", "Software engineering");
        System.Console.WriteLine(sentence);

        // Printing Empty string
        var myString = string.Empty;
        System.Console.WriteLine(myString);

        string nullString = null;
        string emptyString ="";
        string whitespaceString = " ";
        string tabString ="\t";
        string newlineString ="\n";
        string nonEmptyString = "abc123";

        Console.WriteLine($"IsNullOrEmpty(nullString): {String.IsNullOrEmpty(nullString)}");
        Console.WriteLine($"IsNullOrEmpty(emptyString): {String.IsNullOrEmpty(emptyString)}");
        Console.WriteLine($"IsNullOrEmpty(whitespaceString): {String.IsNullOrEmpty(whitespaceString)}");
        Console.WriteLine($"IsNullOrEmpty(tabString): {String.IsNullOrEmpty(tabString)}");
        Console.WriteLine($"IsNullOrEmpty(newlineString): {String.IsNullOrEmpty(newlineString)}");
        Console.WriteLine($"IsNullOrEmpty(nonEmptyString): {String.IsNullOrEmpty(nonEmptyString)}");

        Console.WriteLine();

        Console.WriteLine($"IsNullOrWhiteSpace(nullString): {String.IsNullOrWhiteSpace(nullString)}");
        Console.WriteLine($"IsNullOrWhiteSpace(emptyString): {String.IsNullOrWhiteSpace(emptyString)}");
        Console.WriteLine($"IsNullOrWhiteSpace(tabString): {String.IsNullOrWhiteSpace(tabString)}");
        Console.WriteLine($"IsNullOrWhiteSpace(newlineString): {String.IsNullOrWhiteSpace(newlineString)}");
        Console.WriteLine($"IsNullOrWhiteSpace(whitespaceString): {String.IsNullOrWhiteSpace(whitespaceString)}");
        Console.WriteLine($"IsNullOrWhiteSpace(nonEmptyString): {String.IsNullOrWhiteSpace(nonEmptyString)}");

        // Date Time
        // DateTime currDateTime = DateTime.Now;
        // System.Console.WriteLine(currDateTime.ToString("dd/MM/yyyy")+currDateTime.ToString(" HH:mm"));

        // MyUser user = new()
        // {
        //     Name = "Raghu",
        //     Id = 23
        // };

        // System.Console.WriteLine(user.ToString());

        var flags = Enumerable.Repeat("Green", 10).ToArray();
        foreach (var flag in flags)
        {
            System.Console.WriteLine("FLAG: " + flag);
        }

        
    }
}