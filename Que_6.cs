using System;

class Program
{
    public static void Main()
    {
        string defaultString = "hey there !";
        
        string combinedString = LowUpper(defaultString);
        Console.WriteLine(combinedString);

        Count(defaultString);
    }

    public static string LowUpper(string input)
    {
        string lowerCase = input.ToLower();
        string upperCase = input.ToUpper();
        return lowerCase + upperCase;
    }

    public static void Count(string input)
    {
        int characterCount = input.Length;
        Console.WriteLine("The amount of characters is " + characterCount + ".");
    }
}
