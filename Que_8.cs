using System;

class Program
{
    static void Main()
    {
        int x;
        Console.WriteLine("Enter Number:");
        x = Convert.ToInt32(Console.ReadLine());
        NestedCheck(x);
    }

    public static void NestedCheck(int value)
    {
        if (value % 3 == 0)
        {
            Console.WriteLine("Divisible by 3.");
        }
        else if (value % 7 == 0)
        {
            Console.WriteLine("Divisible by 7.");
        }
        else 
        {
            if (value % 2 != 0)
            {
                 Console.WriteLine("Odd number.");
            }
             else
             {
                Console.WriteLine("Even number.");
            }
         }
    }
}
