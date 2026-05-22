namespace MyApp2.Basics;
struct Book
{
    public int BookId;
    public string BookName;
}
public class StructDs
{
    public static void Run()
    {
        Book b1 = new()
        {
            BookId = 90,
            BookName = "Win or Lose"
        };

        Book b2 = new()
        {
            BookId = 90,
            BookName = "Win or Lose"
        };

        System.Console.WriteLine(b1.BookId);
    }
}