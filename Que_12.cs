using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a temperature: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int temperature))
        {
            string result = temperature <= 15 ? "it is too cold here" :
                            temperature >= 16 && temperature <= 28 ? "it is ok" :
                            "it is hot here";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Not a valid Temperature");
        }
    }
}


// OUTPUT:
// Enter a temperature: 15
// it is too cold here


