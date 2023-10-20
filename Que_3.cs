using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string here: ");
        string inputString = Console.ReadLine();
        Console.Write("Enter the character to search: ");
        char charToSearch = Console.ReadLine()[0];
        int indexOfChar = inputString.IndexOf(charToSearch);
        Console.WriteLine($"\nIndex of '{charToSearch}' in the string: {indexOfChar}");
        Console.Write("\nEnter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        Console.WriteLine($"Full Name: {fullName}");
    }
}
