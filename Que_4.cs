using System;
class P4
{
    static void Main()
    {
        int intValue = 10; 
        double doubleValue = 3.14159; 
        bool boolValue = true; 
        char charValue = 'K'; 
        byte byteValue = 127; 
        short shortValue = 32000; 
        long longValue = 1234567890L; 
        float floatValue = 1.23f; 
        decimal decimalValue = 123.456m; 

        string firstString = "I control text";
        string secondString = "Hello, world!";

        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"string 1: {firstString}");
        Console.WriteLine($"string 2: {secondString}");
    }
}