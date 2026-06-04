namespace MyApp2.Basics;

public class NamedArguments
{
    static int Rectagle(int length,int width )
    {
        return length * width;
    }
    public static void Run()
    {
        Rectagle(
            length: 24,
            width: 25
            );
    }
}