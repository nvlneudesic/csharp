using System;

namespace SquareRoot
{
    class Program
    {
        public static void Main()
        {
            double x;
            Console.Write("Enter the number for which u want a Squareroot : ");
            x = int.Parse(Console.ReadLine());


            Console.Write(Math.Sqrt(x));
        }
    }
}