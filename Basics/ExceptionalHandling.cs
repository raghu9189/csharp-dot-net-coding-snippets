class ExceptionalHandling
{
    public static void ModifyNumber(ref int? Number)
    {
        if (Number != null)
        {
            Number += 90;
        }
        else
        {
            Number = 10;
        }
    }
    public static void ReadNumber(in int? Number)
    {
        System.Console.WriteLine($"The Number is {Number}");
    }
    public static void Run()
    {
        try
        {
            int? number;
            int? MyNumber = 0;
            number = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"Your number is {number}");
            System.Console.WriteLine($"Before {MyNumber}");
            ModifyNumber(ref MyNumber);
            System.Console.WriteLine($"After {MyNumber}");

            System.Console.WriteLine($"Reading the number");
            ReadNumber(in MyNumber);
        }
        catch (System.FormatException)
        {
            
            System.Console.WriteLine("Format is incorrect");
        }
        catch (System.OverflowException)
        {
            
            System.Console.WriteLine("Exceeded limit");
        }
        System.Console.WriteLine(" End of the prompt");

        // System.FormatException
        // System.OverflowException
    }
}