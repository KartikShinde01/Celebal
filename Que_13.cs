using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Using For Loop:");
        ForLoop();
        
        Console.WriteLine("\nUsing While Loop:");
        WhileLoop();
    }

    public static void ForLoop()
    {
        for (int i = -3; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void WhileLoop()
    {
        int value = 3;
        while (value >= -3)
        {
            Console.WriteLine(value);
            value--;
        }
    }
}

// OUTPUT:
// Using For Loop:
// -3
// -2
// -1
// 0
// 1
// 2
// 3

// Using While Loop:
// 3
// 2
// 1
// 0
// -1
// -2
// -3
