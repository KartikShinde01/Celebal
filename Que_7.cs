using System;

class Program
{
    public static void Main()
    {
        int numberToCheck = 7; 
        Check(numberToCheck);
    }

    public static void Check(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}
