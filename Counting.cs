using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class Counting
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 25; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }

            double r = 1;
            while (r <=10)
            {
                Console.WriteLine(r);
                r += .5;
            }
        }
    }
}
