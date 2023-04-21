
namespace cassignments.Day1
{
    public class Fibonaccinumber  //inbetween integer
    {
       public void findFibonacciSeries(int lowerLimit, int upperLimit)
        {
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fibonacci series between {num1} and {num2}:");

            int a = 0, b = 1, c = 0;

            while (a <= num2)
            {
                if (a >= num1)
                {
                    Console.Write(a + " ");
                }

                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        } 
        
    }

        }

