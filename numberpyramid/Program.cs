using System;

class Program
{
    static void Main(string[] args)
    {
        int maxBase = 32;

        for (int i = 1; i <= maxBase; i += 2)
        {
            int spaces = (maxBase - i) / 2;

            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("12");
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}