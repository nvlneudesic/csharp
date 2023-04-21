using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassignments.Day1
{
    public class Reversenumber
    {
        public void revserse(int args)
        {
            int n, reverse = 0, rem;
            Console.Write("Enter a number to Reverse: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            
            Console.WriteLine("Reversed Number:" + reverse);
        }

    }
}
