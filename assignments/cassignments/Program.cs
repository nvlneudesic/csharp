using cassignments.Day1;

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consonents cs = new Consonents();
            cs.consonent("a");

            Fibonaccinumber fn=new Fibonaccinumber();
            fn.findFibonacciSeries(5,9);

            squareroot sq=new squareroot();
            sq.squareroots(6);

            Reversenumber rn = new Reversenumber();
            rn.revserse(45);

            pyramid pr=new pyramid();
            pr.pyramidstruc();
            
        }
    }
}