using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassignments.Day1
{
    public class pyramid
    {
        public void pyramidstruc()
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
                    
                    Console.Write("*");
                }

                Console.WriteLine("pyramid structure:");
            }
        }
    }
}
