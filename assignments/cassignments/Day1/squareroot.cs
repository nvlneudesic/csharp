using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassignments.Day1
{
    public class squareroot
    {
        public void squareroots(double args)
        {
            //double x;
            //Console.Write("Enter the number for which u want a square root :");
            //x=int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Sqrt(x)); //actuall logic

            Console.Write("Enter a number which squareroot is: ");
            double num = double.Parse(Console.ReadLine());

            double root = num / 2;
            double prevRoot = 0;

            while (root != prevRoot)
            {
                prevRoot = root;
                root = (num / prevRoot + prevRoot) / 2;
            }

            Console.WriteLine($"The square root of {num} is {root}");
        }
    }
    }

