using System;
class Program {
public static void Main(string[] args)
{
    string s1 = "0.85";
    float floatVariable = float.Parse(s1); // Parse the string into a float
    
    string s2="12345";
    int intVariable = int.Parse(s2); // Parse the string into an int

    Console.WriteLine($"Parsed float: {floatVariable}"); 
    Console.WriteLine($"Parsed int: {intVariable}");
    }
}
