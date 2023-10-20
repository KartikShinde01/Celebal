using System;
class Program
{
        static void Main()
    {
        string inputString;

        Console.WriteLine("Please enter your name and press enter: ");
        inputString = Console.ReadLine();

        string uppercaseString = inputString.ToUpper();
        Console.WriteLine("Uppercase: " + uppercaseString);

        string lowercaseString = inputString.ToLower();
        Console.WriteLine("Lowercase: " + lowercaseString);

        string trimmedString = inputString.Trim();
        Console.WriteLine("Trimmed: " + trimmedString);

        int substringLength = 5;
        string substring = inputString.Substring(0, Math.Min(substringLength, inputString.Length));
        Console.WriteLine("Substring: " + substring);
    }
}
