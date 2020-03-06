using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.cs
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {

            double[] nbrArray = new double[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please Enter a number: ");
                nbrArray[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The lowest number is {nbrArray.Min()}, the highest number is {nbrArray.Max()} and the average " +
                $"is {nbrArray.Average()}.");
        }
    }
}
